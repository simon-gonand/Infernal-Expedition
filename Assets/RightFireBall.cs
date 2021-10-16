using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFireBall : MonoBehaviour
{
    public GameObject ball;

    private void Fire()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject clone = Instantiate(ball, transform.position + new Vector3(0.5f, 0.0f, 0.0f), transform.rotation);
            Rigidbody rb = clone.AddComponent<Rigidbody>();
            rb.velocity = new Vector3(30, 0, 0);
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
