using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWoodPlat : MonoBehaviour
{

    public GameObject woodPlat;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Daruma")
        {
            woodPlat.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Daruma")
        {
            woodPlat.SetActive(false);
        }
    }

}
