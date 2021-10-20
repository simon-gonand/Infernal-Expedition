using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public PlayerInputManager pim;
    public Transform boat;

    // Start is called before the first frame update
    void Start()
    {
        pim.onPlayerJoined += AssignBoat;

    }

    // Update is called once per frame
    void Update()
    {
    }

    void AssignBoat(PlayerInput pi)
    {
        Debug.Log("Hello World !");
        pi.transform.GetComponent<PlayerController>().boatTransform = boat;
    }
}
