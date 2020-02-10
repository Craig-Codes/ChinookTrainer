using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfoText : MonoBehaviour
{
    //Script is used to display and hide a group of UI elements togher - Canvas group needs created inside Unity first
    public GameObject groupToHide; // Add In a UI Group inside Unity
    private bool pressed = true; // variable controls which state the button controlling the mouseDown event is in.

    // Start is called before the first frame update
    void Start()
    {
        groupToHide.GetComponent<CanvasGroup>().alpha = 0f; // Group of UI elements starts off hidden
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (!pressed)
        {
            groupToHide.GetComponent<CanvasGroup>().alpha = 0f;
            pressed = true;
        }
        else
        {
            pressed = false;
            groupToHide.GetComponent<CanvasGroup>().alpha = 1f;
        }
    }
}
