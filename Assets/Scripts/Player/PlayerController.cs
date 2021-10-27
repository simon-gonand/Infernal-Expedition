using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Header("Stat")]
    private float playerSpeed;
    [SerializeField]
    [Range(0,2)]private float interactionDistance;

    [Header("Boat References")]
    public Transform boatTransform;

    [Header("Self References")]
    public Transform self;
    /*[SerializeField]
    private Rigidbody selfRigidbody;*/
    [SerializeField]
    private PlayerInput playerInput;


    private Vector2 playerMovementInput = Vector2.zero;
    private IInteractable interactingWith;
    private bool _isInteracting = false;
    public bool isInteracting { get { return _isInteracting; } set { _isInteracting = value; } }

    // Start is called before the first frame update
    void Start()
    {
        boatTransform = BoatMovements.instance.self;

        playerInput.actionEvents[1].AddListener(BoatMovements.instance.OnMove);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovementInput = context.ReadValue<Vector2>();
    }

    public void OnInteraction(InputAction.CallbackContext context)
    {
        //Debug.Log(context.performed);
        if (!isInteracting && context.performed)
        {
            Vector3 startRayPos = self.position;
            startRayPos.y -= self.lossyScale.y / 2;

            RaycastHit hit;
            int layerMask = 1 << LayerMask.NameToLayer("Equipment");
            if (Physics.Raycast(startRayPos, self.forward, out hit, interactionDistance, layerMask))
            {
                interactingWith = hit.collider.gameObject.GetComponent<IInteractable>();
                interactingWith.InteractWith(this);
            }
        }
        else if (isInteracting && context.performed)
        {
            interactingWith.UninteractWith(this);
        }
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
        if (!isInteracting)
            PlayerMovement();
    }
}
