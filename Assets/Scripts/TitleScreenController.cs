using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour
{
    public GameObject titleCanvas;
    public GameObject levelCanvas;
    public GameObject creditsCanvas;
    public GameObject BBTCanvas;
    public GameObject ESGCanvas;
    public GameObject BBTLoadingCanvas;
    public GameObject ESGLoadingCanvas;

    private void Start(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;

        titleCanvas.SetActive(true);
        levelCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        BBTCanvas.SetActive(false);
        ESGCanvas.SetActive(false);
        BBTLoadingCanvas.SetActive(false);
        ESGLoadingCanvas.SetActive(false);
    }

    public void LoadTitleCanvas(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;
        titleCanvas.SetActive(true);
        levelCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        BBTCanvas.SetActive(false);
        ESGCanvas.SetActive(false);
    }

    public void LoadLevelCanvas(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;
        titleCanvas.SetActive(false);
        levelCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
        BBTCanvas.SetActive(false);
        ESGCanvas.SetActive(false);
    }

    public void LoadCreditsCanvas(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;
        titleCanvas.SetActive(false);
        levelCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
        BBTCanvas.SetActive(false);
        ESGCanvas.SetActive(false);
    }

    public void LoadBBTCanvas(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;
        titleCanvas.SetActive(false);
        levelCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        BBTCanvas.SetActive(true);
        ESGCanvas.SetActive(false);
    }

    public void LoadESGCanvas(){
        if(!titleCanvas && !levelCanvas && !creditsCanvas && !BBTCanvas && !ESGCanvas)
            return;
        titleCanvas.SetActive(false);
        levelCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        BBTCanvas.SetActive(false);
        ESGCanvas.SetActive(true);
    }

    public void LoadLevel(int index){
        if(index == 1){
            BBTLoadingCanvas.SetActive(true);
        }
        else if(index == 2){
            ESGLoadingCanvas.SetActive(true);
        }
        SceneManager.LoadScene(index);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
