using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceSphere : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Apply a force to keep the sphere balanced on the plane
        rb.AddForce(Vector3.up * Physics.gravity.y);
    }
}
