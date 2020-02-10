using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetModel : MonoBehaviour
{
    // Script returns game objects back to thier original colour after they have been made transparent from the TransparentExterior script
    public GameObject[] exteriorColorArray; //Arrays hold gameObjects which use the same shader
    public GameObject[] exteriorSpecularArray;
    public GameObject[] rotorColorArray;
    public GameObject[] windowsArray;
    public Material exteriorColor; // materials hold the diferent shaders required to make the model back to visible and the correct color again
    public Material exteriorSpecular;
    public Material rotorColor;
    public Material windowMaterial;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        // On click the arrays are looped though, with each different material type being applied to all the game objects in the array
        for (int i = 0; i < exteriorColorArray.Length; i++)
        {
            exteriorColorArray[i].GetComponent<Renderer>().material = exteriorColor;
        }

        for (int i = 0; i < exteriorSpecularArray.Length; i++)
        {
            exteriorSpecularArray[i].GetComponent<Renderer>().material = exteriorSpecular;
        }

        for (int i = 0; i < rotorColorArray.Length; i++)
        {
            rotorColorArray[i].GetComponent<Renderer>().material = rotorColor;

        }

        for (int i = 0; i < windowsArray.Length; i++)
        {
            windowsArray[i].GetComponent<Renderer>().material = windowMaterial;
        }

    }
}
