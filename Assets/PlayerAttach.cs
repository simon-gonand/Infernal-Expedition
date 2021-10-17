using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    private GameObject container;
    private void OnTriggerEnter(Collider other)
    {
        // prevent player object to be deformed
        // https://stackoverflow.com/questions/63351469/object-deforms-when-it-becomes-a-child-of-a-gameobject
        if (other.tag == "Player")
        {
            container = new GameObject("container");

            Vector3 myScale = transform.localScale;
            container.transform.localScale = new Vector3(1f/myScale.x, 1f/myScale.y, 1f/myScale.z);

            container.transform.SetParent(transform, false);
            other.gameObject.transform.SetParent(container.transform);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            other.gameObject.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.SetParent(null);
            Destroy(container);
        }
    }
}
