using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject curCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           // other.transform.position = other.transform.GetComponent<movement.PlayerController>().origin;
            other.transform.GetComponent<movement.PlayerController>().origin = curCheckpoint.transform.position;
        }
    }
}
