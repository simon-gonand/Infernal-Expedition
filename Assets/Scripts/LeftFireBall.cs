using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFireBall : MonoBehaviour
{
    public GameObject ball;

    [SerializeField]
    private float fireSpeed;
    [SerializeField]
    private float fireRate = 1.0f;

    private float nextFire;
    

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
