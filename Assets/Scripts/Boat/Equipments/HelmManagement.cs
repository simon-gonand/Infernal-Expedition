using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmManagement : MonoBehaviour, IInteractable
{
    [SerializeField]
    private Transform self;
    [SerializeField]
    private Transform snapPoint;

    private float steer = 0.0f;

    public void InteractWith(PlayerController player)
    {
        player.isInteracting = true;

        Vector3 newPlayerPosition = snapPoint.position;
        newPlayerPosition.y += player.self.lossyScale.y / 2;
        player.self.position = newPlayerPosition;
        player.self.forward = snapPoint.forward;
    }

    public void UninteractWith(PlayerController player)
    {
        player.isInteracting = false;
    }

    public void OnAction()
    {
        // No action possible
    }

    public void OnMove(Vector2 movements)
    {
        steer = movements.x;
        //self.Rotate(new Vector3(0.0f, 0.0f, movements.x * 45.0f + self.rotation.z));
    }

    private void FixedUpdate()
    {
        BoatMovements.instance.Steer(steer);
    }
}
