using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCenterOfMass : MonoBehaviour
{
    public Vector3 com;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
