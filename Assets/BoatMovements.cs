using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovements : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void SetVelocity()
    {
        rb.velocity = new Vector3 (0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        SetVelocity();
    }
}
