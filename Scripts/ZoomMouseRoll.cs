using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMouseRoll : MonoBehaviour { 
    private float movementSpeed = 0.5f; // Speed that camera moves

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        var wheel = Input.GetAxis("Mouse ScrollWheel"); // mouse input
        //Scrollwheel gives us a scale between 1 and -1, we use 0 and above to go forward, and anything less to move the camera backwards
        if (wheel > 0f) // Moves camera foward
        {
            Camera.main.transform.Translate(Vector3.forward * movementSpeed);
        }
        else if (wheel < 0f)
        {
            Camera.main.transform.Translate(Vector3.back * movementSpeed);
        }
    }
}