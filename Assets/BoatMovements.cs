using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovements : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private void SetVelocity()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        SetVelocity();
    }
}
