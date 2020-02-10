using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Need this to access UI elements

public class UiDisplay : MonoBehaviour
{
    public Text UiToDisplay; //Text we want to show when an item is clicked
    public Text[] OtherUiToHideArray; //Array of all other UI elements, so that only one is shown at once
    private bool pressed = false; // boolean to control if the element was pressed so that text can be turned off if it's pressed a second time.

    // Start is called before the first frame update
    void Start()
    {
        UiToDisplay.gameObject.SetActive(false); // Starts the UI element as hidden (Can also do this in Unity with the Tick by name field to keep it tidy in game
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
       // OnMouseDown event, script checks to see if the button has already been pressed or not
        if (!pressed)
        {
            UiToDisplay.gameObject.SetActive(true);//Display the UI
            pressed = true;

            //Hides all other UI element text so that only the one we want is displayed
            for(var i = 0; i <OtherUiToHideArray.Length; i++)
            {
                OtherUiToHideArray[i].gameObject.SetActive(false);
            }
        }
        else
        {
            UiToDisplay.gameObject.SetActive(false);
            pressed = false;
        }
    }

}
