using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour {

    Rigidbody rb;
    public int ballSpeed = 0;
    public int jumpSpeed = 0;
    public bool isFlat = true;
    public bool inContact = true;
    private int counter; //This is made private so that it is not visible in the inspector panel.
    public Text cointext;
    public AudioSource aSource;
    public AudioClip aClip;

    // Start is called before the first frame update
    void Start() {

        rb = GetComponent<Rigidbody>();

        counter = 7;
         cointext.text = counter + " COINS LEFT";
        
    }

    // Update is called once per frame
    void Update(){
      

       Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        

        rb.AddForce(tilt * ballSpeed);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.red);

        if((Input.touchCount > 0) && inContact == true) {
            Vector3 ballJump = new Vector3(0.0f, 6.0f, 0.0f);
            rb.AddForce(ballJump * jumpSpeed); 
        }

        inContact = false;

          
    }

    private void OnCollisionStay() /* Part of the monoBehavior class */  {
        inContact = true;
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Coinstag")){
            other.gameObject.SetActive (false);

            counter = counter - 1; //Increase the counter by 1.
             cointext.text = counter.ToString() + " COINS LEFT";

             aSource.PlayOneShot (aClip);

             if (counter == 0){
                SceneManager.LoadScene("EndScene"); 
             }
        }
    }

}
