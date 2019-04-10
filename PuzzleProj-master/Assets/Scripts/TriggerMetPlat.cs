using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMetPlat : MonoBehaviour
{
    public GameObject metPlat;
    public float delay = 0.5f;

    IEnumerator ActiMetPlat()
    {
        yield return new WaitForSeconds(delay);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Daruma")
        {
            metPlat.SetActive(true);
            StartCoroutine("ActiMetPlat");
            metPlat.GetComponent<Rigidbody>().useGravity = true;
        }
    }

}
