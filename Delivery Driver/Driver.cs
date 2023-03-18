using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] float driverSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * driverSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            driverSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       
        driverSpeed = slowSpeed;
    }
}
