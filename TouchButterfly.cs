using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButterfly : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            anim.Play("Take 001");
            Debug.Log("You have touched the screen");

        }
    }
}
