using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    private NPCMove move;
    private NPCAim aim;
    private NPCTalk talk;
    private Animator anim;

    Quaternion lookDir;

    private void Start(){
        move = GetComponent<NPCMove>();
        aim = GetComponent<NPCAim>();
        talk = GetComponent<NPCTalk>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update(){
        SetDirection();
        SetMoving();
        SetTalking();
    }

    private void SetDirection(){
        lookDir = Quaternion.LookRotation(aim.GetAimDirection());

         if (lookDir.eulerAngles.y >= 337.5 || lookDir.eulerAngles.y < 22.5){
            // Up
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        }
		else if (lookDir.eulerAngles.y >= 22.5 && lookDir.eulerAngles.y < 67.5){
			// Up Right
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        }
		else if (lookDir.eulerAngles.y >= 67.5 && lookDir.eulerAngles.y < 112.5){
			// Right
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        }
		else if (lookDir.eulerAngles.y >= 112.5 && lookDir.eulerAngles.y < 157.5){
			// Down Right
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        }
        else if (lookDir.eulerAngles.y >= 157.5 && lookDir.eulerAngles.y < 202.5){
			// Down
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
		else if (lookDir.eulerAngles.y >= 202.5 && lookDir.eulerAngles.y < 247.5){
			// Down Left
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
		else if (lookDir.eulerAngles.y >= 247.5 && lookDir.eulerAngles.y < 292.5){
			// Left
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
		else if (lookDir.eulerAngles.y >= 292.5 && lookDir.eulerAngles.y < 337.5){
			// Up Left
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
    }

    private void SetMoving(){
        anim.SetBool("moving", !move.IsStopped());
    }

    private void SetTalking(){
        anim.SetBool("talking", talk.isInConversation());
    }

}
