using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetView : MonoBehaviour
{
    private GameObject CameraFocalPoint; //Blank game object in the middle of the Chinook model
    private Vector3 startPosition; // Cameras starting point saved into a vetor 3
    private float mainCameraX;
    private float mainCameraY;
    private float mainCameraZ;

    // Start is called before the first frame update
    void Start()
    {
        CameraFocalPoint = GameObject.Find("Camera Focal Point");
        startPosition = CameraFocalPoint.transform.position;

        mainCameraX = Camera.main.transform.position.x;
        mainCameraY = Camera.main.transform.position.y;
        mainCameraZ = Camera.main.transform.position.z;

    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        // On button press, function resets the cameras rotation and location (based on the variables aquired on start)
        CameraFocalPoint.transform.position = startPosition;
        CameraFocalPoint.transform.rotation = Quaternion.Euler(0, 0, 0); // Quaternion.Euler used the same as Vector3 but for rotation instead of position
        Camera.main.transform.position = new Vector3(mainCameraX, mainCameraY, mainCameraZ); // Transform coordinates of the camera at the start
    }
}
