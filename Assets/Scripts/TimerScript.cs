using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour{
    float currentTime = 0f, startTime = 10f;
    public Text TimerText;

    void Start() {
        currentTime = startTime;
    }

    void Update() {
        currentTime -= 1 * Time.deltaTime;

        string minutes = (currentTime / 60).ToString("f0");
        string seconds = (currentTime % 60).ToString("f2");
        

        TimerText.text = minutes + " : " + seconds;

        if(currentTime <= 0){
            currentTime = 0;
            SceneManager.LoadScene("MainScene");
        }
    }
}