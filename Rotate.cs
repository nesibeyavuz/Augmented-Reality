using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rotate the propeller of the airplane
public class Rotate : MonoBehaviour
{
	public Vector3 vect;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(vect * Time.deltaTime);
    }
}
