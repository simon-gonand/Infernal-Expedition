using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoatMovements : MonoBehaviour
{
    [SerializeField]
    private float minSpeed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float steerSpeed;

    private Rigidbody rb;

    private Vector2 movementInput = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void SetVelocity()
    {
        float axisValue = movementInput.y;
        if (axisValue < 0 && speed > minSpeed || axisValue > 0 && speed < maxSpeed)
            speed += axisValue;
        rb.velocity = transform.forward * Time.deltaTime * speed;
    }

    private void Steer()
    {
        float steering = movementInput.x * steerSpeed;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, steering, 0) * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        SetVelocity();
        Steer();
    }
}
