using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private Rigidbody boatRigidbody;
    [SerializeField]
    private GameObject boatObj;
    [SerializeField]
    private Transform self;

    private Vector2 playerMovementInput = Vector2.zero;
    private bool isOnBoat;
    private Vector3 currentMove;

    // Start is called before the first frame update
    void Start()
    {
        isOnBoat = false;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovementInput = context.ReadValue<Vector2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == boatObj)
            isOnBoat = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == boatObj)
            isOnBoat = false;
    }

    private void PlayerMovement()
    {
        Vector3 move = new Vector3(playerMovementInput.x, 0.0f, playerMovementInput.y);
        if (isOnBoat && boatRigidbody.velocity != Vector3.zero)
            move.Scale(boatRigidbody.velocity);
        controller.Move(move * Time.deltaTime * playerSpeed);
        if (move != Vector3.zero)
            self.forward = move;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
}
