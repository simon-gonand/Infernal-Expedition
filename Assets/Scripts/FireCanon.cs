using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Plane = UnityEngine.Plane;

public class FireCanon : MonoBehaviour
{
    public GameObject ball;

    [SerializeField]
    private float fireSpeed;
    [SerializeField]
    private float fireRate = 1.0f;

    [SerializeField]
    private Transform self;
    [SerializeField]

    private float nextFire;

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
        /* if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
         {
             GameObject clone = Instantiate(ball, transform.position, transform.rotation);
             Rigidbody rb = clone.AddComponent<Rigidbody>();
             rb.velocity = transform.forward * Time.deltaTime * fireSpeed;

             nextFire = Time.time + fireRate;
         }*/
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
}
