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
    [SerializeField]
    private Rigidbody boatRigidbody;
    [SerializeField]
    private GameObject boatObj;
    [SerializeField]
    private Transform boatTransform;

    [Header("Self References")]
    [SerializeField]
    private Transform self;
    [SerializeField]
    private Rigidbody selfRigidbody;

    private Vector2 playerMovementInput = Vector2.zero;
    private bool isOnBoat;
    private GameObject container;

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

        container = new GameObject("container");

        Vector3 myScale = boatTransform.localScale;
        container.transform.localScale = new Vector3(1f/myScale.x, 1f/myScale.y, 1f/myScale.z);

        container.transform.SetParent(boatTransform, false);
        self.SetParent(container.transform);
        selfRigidbody.isKinematic = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == boatObj)
            isOnBoat = false;

        self.SetParent(null);
        Destroy(container);
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
