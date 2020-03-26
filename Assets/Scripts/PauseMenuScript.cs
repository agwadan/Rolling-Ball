using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour{

    public void resumeGame(){
        Debug.Log("Game Resumed...");
    }
    
    public void restartGame(){
        SceneManager.LoadScene("MainScene");
    }


    public void quitGame(){
        SceneManager.LoadScene("MenuScene");
    }

     public void exitGame(){
        Debug.Log("Exited...");
        Application.Quit();
    }

    

    
}
