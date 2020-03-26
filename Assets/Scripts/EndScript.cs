using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour{
    public void restart(){
       SceneManager.LoadScene("MainScene");
   }
   
   public void exitgame(){
       Debug.Log("Exited...");
       Application.Quit();
   }
}
