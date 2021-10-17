using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.SetParent(transform);
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.SetParent(null);
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
