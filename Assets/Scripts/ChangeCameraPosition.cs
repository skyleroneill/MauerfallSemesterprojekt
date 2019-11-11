using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    public FollowCamera cam;
    public Transform newTarget;
    public Transform oldTarget;
    public bool revertOnInput;
    public float range = 3f;

    private bool atNewTarget = false;
    private bool isListener = false;
    
    private void Update(){
        if(!isListener){
            InteractAbility.interact.onInteractPressed += TargetNew;
            isListener = true;
        }

        if(atNewTarget && revertOnInput && Input.anyKeyDown){
            // Change to old target
            cam.SetTarget(oldTarget);
            atNewTarget = false;
        }
    } 

    public void TargetNew(){
        // Remove this method as a listener
        if(this == null){
            InteractAbility.interact.onInteractPressed -= TargetNew;
            return;
        }

        // Change to new target
        if(!atNewTarget && Vector3.Distance(transform.position, oldTarget.position) <= range){
            cam.SetTarget(newTarget);
            StartCoroutine(WaitToSetAtNewTarget());
        }
    }

    IEnumerator WaitToSetAtNewTarget(){
        yield return new WaitForSeconds(0.1f);
        atNewTarget = true;
    }
}
