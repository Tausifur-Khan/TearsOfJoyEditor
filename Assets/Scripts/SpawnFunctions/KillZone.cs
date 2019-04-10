using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{  
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = other.transform.GetComponent<movement.PlayerController>().origin;
           
        }
        if(other.tag == "Daruma")
        {
            other.transform.position = other.transform.GetComponent<ReSpawn>().origin;
        }
    }

}
