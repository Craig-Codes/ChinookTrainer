using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    // Need to check we have two touches, then work out the distance. If they have moved further, zoom out, if moved closer zoom in
    // Unity tutorial - https://www.youtube.com/watch?v=srcIPtyWlMs

    public float perspectiveZoomSpeed = 0.5f; // // The rate of change of the field of view in perspective mode.
    public Camera camera;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    private void Update()
    {
        if (Input.touchCount == 2) // Checks to ensure there are two touches on the screen
        {
            // Store both touches
            Touch touchZero = Input.GetTouch(0); // Get both touches from the touches array and store in variables
            Touch touchOne = Input.GetTouch(1);

            // Need to find out where touches positions where
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition; // current position is subtracted from delta position (previous frame position)
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find distance between each touch in each frame. Subtract one touches postiion from the other to get a vector.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // If negative figure, fingers are moving closer (zoom-in), if positive figure figners moving further away(zoom-out)
            if (deltaMagnitudeDiff > 0)
            {
                Camera.main.transform.Translate(Vector3.back * perspectiveZoomSpeed);
            }
            if (deltaMagnitudeDiff < 0)
            {
                Camera.main.transform.Translate(Vector3.forward * perspectiveZoomSpeed);
            }
        }
    }
}
