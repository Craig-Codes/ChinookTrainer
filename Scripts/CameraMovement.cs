using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  
    // Main Camera is nested under the blank game object 'focal point' within unity, so that it rotates when focal point object rotates
    public float rotationSpeed; // public variable set inside Unity Engine to control how fast camera moves
    private float buttonTimer = 2.0f; // variable ensures the camera doesnt move when a quick click is made, essentially setting a slight delay before the function triggers.

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount != 2) // Used to ensure compatibility with touch devices... Only working if 2 fingers arnt on the screen
        {

            if (Input.GetMouseButton(0)) // Checks to see if left mouse button is being pressed
            {

                buttonTimer -= 0.2f; // Each update runs 0.02 secs... to delay the timer, 0.2 is coming off 2.0f approx every 0.02 secs

                if (buttonTimer < 0)
                {
                    // Using minus rotation speed changes the direction of the spin.
                    float horizontalInput = Input.GetAxis("Mouse X"); // Variable to hold the horizontal input (either 1 for right or -1 for left)
                    transform.Rotate(Vector3.down, horizontalInput * -rotationSpeed * Time.deltaTime);

                    float verticalInput = Input.GetAxis("Mouse Y"); // Variable to hold the vertical input (either 1 for up or -1 for down)
                    transform.Rotate(Vector3.right, verticalInput * -rotationSpeed * Time.deltaTime);
                }
            }

            else if (!Input.GetMouseButton(0))
            {
                buttonTimer = 2.0f; //If the mouse is no longer pressed, the timer is reset.

            }

        }

    }

}
