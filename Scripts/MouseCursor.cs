using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    /* Script is used to add a hand hover to buttons and certain components
    Script needs to be added to every tagged component. Each component needs a box collider
    add the cursor image to the public Texture2D in the class when it's added to the object in Unity
    */

    public Texture2D mousePoint; // Add the mouse pointer cursor texture here inside Unity
    public Texture2D mouseHold; // add additional mouse pointers here...
    public CursorMode curMode = CursorMode.Auto; // use software mouse as the custom mouse. Ensures our custom cursor is used
    public Vector3 hotSpot = Vector3.zero; // use Vector2 if 2d canvas. Sets the mouse offset, with 0 top left

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(null, hotSpot, curMode); // starts mouse as default
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseEnter()
    {
        // Game objects we want the cursor to change over must be tagged with the custom 'MagicCursor' tag created inside Unity
        if (gameObject.tag == "MagicCursor")
        {
            Cursor.SetCursor(mousePoint, hotSpot, curMode); // Sets cursor to the hand pointer
        }
    }
    // add in more if's or use a larger switch if you have loads of options! e.g (gameObject.tag == "Button") (gameObject.tag == "Box")... or Switch(gameObject) case "Button":, case: "Box"


    public void OnMouseExit()
    {
        Cursor.SetCursor(null, hotSpot, curMode); // returns mouse to default once it's left the object
    }

}
