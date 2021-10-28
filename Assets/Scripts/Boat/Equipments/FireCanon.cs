using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCanon : MonoBehaviour, IInteractable
{
    public GameObject ball;

    [SerializeField]
    private float fireSpeed;
    [SerializeField]
    private float fireRate = 1.0f;

    [SerializeField]
    private Transform self;
    [SerializeField]
    private Transform snapPoint;

    private float nextFire;

    public void InteractWith(PlayerController player)
    {
        player.isInteracting = true;

        // Snap player to the canon
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
        Fire();
    }

    public void OnMove(Vector2 movements)
    {
        // Turn canon ?
    } 

    private void Fire()
    {
        if (Time.time > nextFire)
        {
            Vector3 ballSpawnPosition = self.position;
            ballSpawnPosition.x += self.lossyScale.x;
            GameObject ballClone = Instantiate(ball, ballSpawnPosition, self.rotation);
            Rigidbody rb = ballClone.AddComponent<Rigidbody>();
            rb.velocity = transform.forward * Time.deltaTime * fireSpeed;

            ballClone.GetComponent<CanonBallLifeSpan>().SetCanonWhichFired(self);

            nextFire = Time.time + fireRate;
        }
    }
}
