using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{

    public GameObject ballsphere;
    private Vector3 distance;

    // Start is called before the first frame update
    void Start(){
        distance = transform.position - ballsphere.transform.position; //Getting initial distance between the camera and the sphere.
    }

    // Update is called once per frame
    void Update(){
        transform.position = distance + ballsphere.transform.position; //Keeping a safe distance between the camera and the sphere.
    }
}
