using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Material player1Material;
    [SerializeField]
    private Material player2Material;
    [SerializeField]
    private Material player3Material;
    [SerializeField]
    private Material player4Material;


    public void OnPlayerJoined(PlayerInput playerInput)
    {
        switch (playerInput.playerIndex)
        {
            case 0:
                playerInput.gameObject.GetComponent<MeshRenderer>().material = player1Material;
                break;
            case 1:
                playerInput.gameObject.GetComponent<MeshRenderer>().material = player2Material;
                break;
            case 2:
                playerInput.gameObject.GetComponent<MeshRenderer>().material = player3Material;
                break;
            case 3:
                playerInput.gameObject.GetComponent<MeshRenderer>().material = player4Material;
                break;
            default:
                break;
        }
    }
}
