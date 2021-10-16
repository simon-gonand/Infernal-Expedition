using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingBoat : MonoBehaviour
{
    public Transform boat;
    private Vector3 initialOffset;

    // Start is called before the first frame update
    void Start()
    {
        initialOffset = transform.position - boat.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = boat.position + initialOffset;
    }
}
