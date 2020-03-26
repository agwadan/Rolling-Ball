using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool pauseStatus = false;
    public GameObject pauseMenuUI;

   

    public void pauseButtonClick(){
     //  if(Input.GetKeyDown(KeyCode.Escape)){

           if(pauseStatus){
               Resume();
           }

           else{
               Pause();
           }

    }
       
       public void Resume(){
           pauseMenuUI.SetActive(false);//---------Deactivating the pause menu panel designed in unity.
           Time.timeScale = 1f;//------------------Setting the speed at which time is moving back to normal.
           pauseStatus = false; 
       }

       void Pause(){
           pauseMenuUI.SetActive(true);//----------Activating the pause menu panel designed in unity.
           Time.timeScale = 0f;//------------------Setting the speed at which time is moving to Zero.
           pauseStatus = true;
       }

       public void Quit(){
           Time.timeScale = 1f;
           Debug.Log("Game Quitted..");
           SceneManager.LoadScene("MenuScene");//---Loading Main Menu when a player quits the game. 
       }

       public void Restart(){
           Time.timeScale = 1f;
           Debug.Log("Game Restarted...");
           SceneManager.LoadScene("MainScene");//---Restarts the main Scene When the player restarts the game.
       }
    
}
