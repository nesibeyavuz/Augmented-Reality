using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reset the position of the airplane when it hits WallOne
public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    void Start()
    {
        //We are storing the default location of the airplane
        originalPos = transform.localPosition;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //If the WallOne cube collides with the airplane
        if(other.gameObject.CompareTag("AIRPLANEWALL"))
        {
            transform.localPosition = originalPos;
        }
    }
}
