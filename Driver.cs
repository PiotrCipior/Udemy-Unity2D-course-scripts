using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] float driverSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * driverSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
