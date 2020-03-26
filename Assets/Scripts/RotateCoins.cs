using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour{

    Vector3 turnCoins;

    // Update is called once per frame
    void Update(){

        turnCoins = new Vector3(45, 0, 0); // The 3 arguments for "Vector3 are, X, Y and Z axis respectively"
        transform.Rotate(turnCoins * Time.deltaTime); // "Time.deltaTime allows the coins to rotate smoothly."
    }
}
