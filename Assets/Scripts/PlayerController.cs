using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Header("Stat")]
    private float playerSpeed = 2.0f;

    [Header("Boat References")]
    public Transform boatTransform;

    [Header("Self References")]
    [SerializeField]
    private Transform self;
    [SerializeField]
    private Rigidbody selfRigidbody;
    [SerializeField]
    private PlayerInput playerInput;


    private Vector2 playerMovementInput = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        boatTransform = BoatMovements.instance.transform;
        
        playerInput.actionEvents[1].AddListener(BoatMovements.instance.OnMove);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovementInput = context.ReadValue<Vector2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        self.SetParent(boatTransform);
        selfRigidbody.isKinematic = true;
    }

    private void OnTriggerExit(Collider other)
    {
        self.SetParent(null);
        selfRigidbody.isKinematic = false;
    }

    private void PlayerMovement()
    {
        Vector3 move = new Vector3(playerMovementInput.x, 0.0f, playerMovementInput.y);
        self.Translate(move * Time.deltaTime * playerSpeed, Space.World);
        if (move != Vector3.zero)
            self.forward = move;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
}
