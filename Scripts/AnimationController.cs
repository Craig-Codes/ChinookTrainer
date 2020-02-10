using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Animator animator;
    void Start()
    {
        // Script controls the animation of the propellars
        animator = GameObject.Find("Chinook").GetComponent<Animator>(); // Access the Animator component within the Game Object the animator is inside
        animator.SetBool("startAnimation", true); // the paramenter "startAnimation" is set inside unity animation editor, and is set as a condition (added to the transitions). Can use bools, ints, etc 
       }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OnMouseDown()
    {
        // if animation is playing, stop, else start
        if(animator.GetBool("startAnimation") == false) // checks the animation paramemeter using GetBool
        {
            animator.SetBool("startAnimation", true); // When bool changes the animation starts. Animator in Unity uses this bool to transition from one state to another.
        }
        else {
            animator.SetBool("startAnimation", false); // when bool changes the animation stops
        }
    }
}
