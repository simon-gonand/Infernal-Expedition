using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoatMovements : MonoBehaviour
{
    [SerializeField]
    [Header("Stats")]
    private float minSpeed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float steerSpeed;

    [Header("References")]
    public Rigidbody selfRigidBody;
    public Transform self;

    private Vector2 movementInput = Vector2.zero;


    public static BoatMovements instance;

    private void Awake()
    {
        instance = this;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void SetVelocity()
    {
        float axisValue = movementInput.y;
        if (axisValue < 0 && speed > minSpeed || axisValue > 0 && speed < maxSpeed)
            speed += axisValue;
        selfRigidBody.velocity = self.forward * Time.deltaTime * speed;
    }

    public void Steer(float steering)
    {
        steering *= steerSpeed;
        selfRigidBody.MoveRotation(selfRigidBody.rotation * Quaternion.Euler(new Vector3(0, steering, 0) * Time.deltaTime));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetVelocity();
    }
}
