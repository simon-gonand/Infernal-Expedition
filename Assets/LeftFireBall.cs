using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFireBall : MonoBehaviour
{
    public GameObject ball;

    private float nextFire;
    public float fireRate = 1.0f;

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            GameObject clone = Instantiate(ball, transform.position + new Vector3(-0.5f, 0.0f, 0.0f), transform.rotation);
            Rigidbody rb = clone.AddComponent<Rigidbody>();
            rb.velocity = new Vector3(-30, 0, 0);

            nextFire = Time.time + fireRate;
        }
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
