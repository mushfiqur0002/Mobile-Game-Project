using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private Vector3 gyroRotation;
    private Vector3 initialRotation;

    void Start()
    {

        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            Debug.Log("Gyro Enable");
            // Store the initial rotation of the plane
            initialRotation = transform.rotation.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyroRotation = Input.gyro.rotationRateUnbiased;

            // Apply rotation to the plane only on the X and Z axes
            transform.Rotate(-gyroRotation.x, 0, -gyroRotation.y);
        }
    }
}
