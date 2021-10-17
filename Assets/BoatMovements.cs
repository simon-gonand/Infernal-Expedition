using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovements : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public float speed;
    public float steerSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void SetVelocity()
    {
        float axisValue = Input.GetAxis("Vertical");
        if (axisValue < 0 && speed > minSpeed || axisValue > 0 && speed < maxSpeed)
            speed += axisValue;
        rb.velocity = transform.forward * Time.deltaTime * speed;
    }

    private void Steer()
    {
        float steering = Input.GetAxis("Horizontal") * steerSpeed;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, steering, 0) * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        SetVelocity();
        Steer();
    }
}
