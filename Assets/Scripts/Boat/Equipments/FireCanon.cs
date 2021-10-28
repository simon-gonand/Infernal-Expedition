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

        // Set unity event controllers just as boat just for canon
    }

    public void UninteractWith(PlayerController player)
    {
        player.isInteracting = false;
        // Remove unity events controller
    }

    public void OnAction()
    {
        Fire();
    }

    public void OnMove(Vector2 movements)
    {
        // Turn canon ?
    } 

    /*private void OnColliderEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CapsuleCollider playerCollider = (CapsuleCollider)other;
            Vector3 dir = (other.transform.localPosition - self.localPosition).normalized;
            BoxCollider selfBox = self.GetComponent<BoxCollider>();

            Vector3 capsulePt = playerCollider.center + (Vector3.Scale(-dir,playerCollider.transform.localScale)* playerCollider.radius);

            RaycastHit hit;
            Physics.Linecast(selfBox.center, playerCollider.center, out hit) ;
            Vector3 selfCollPt = hit.point;

            Vector3 offset = capsulePt- selfCollPt;
            offset.y = 0;
            other.transform.localPosition -= offset*0.5f;
        }
    }*/

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
