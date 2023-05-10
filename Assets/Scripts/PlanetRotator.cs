using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour
{
    public float rotationSpeed = 3f;
    public void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); 
    }
}
