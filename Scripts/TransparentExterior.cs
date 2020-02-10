using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentExterior : MonoBehaviour
{
    // The script makes all the game objects in an array semi-transaprent by adding a different shader material to them
    public GameObject[] semiTransparentObjectsArray;
    public Material transparentMaterial;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        // On click the array is looped though and each object is given the Material stored in the transparentmaterial variable, which is assigned in the Unity Engine
        for(int i = 0; i < semiTransparentObjectsArray.Length; i++)
        {
            semiTransparentObjectsArray[i].GetComponent<Renderer>().material = transparentMaterial; // Each array component is given the transparentMaterial which is assigned in unity
        }
       
    }
}
