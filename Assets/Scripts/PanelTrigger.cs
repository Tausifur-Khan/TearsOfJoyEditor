using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    public GameObject dynoPlat;
    public GameObject panel;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Daruma")
        {
            dynoPlat.SetActive(true);
            panel.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        dynoPlat.SetActive(false);
        panel.SetActive(false);
    }
}
