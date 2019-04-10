using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject daruma;
    public float delaySpawn = 0.5f;
    //private PickUp pick;


    IEnumerator SpawnTime()
    {
        daruma.GetComponent<PickUp>().picked = false;
        //pick.picked = false;  
        yield return new WaitForSeconds(delaySpawn);
        daruma.transform.position = spawnPoint.position;  
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "KillZone")
        {
            StartCoroutine("SpawnTime");
        }
    }

}
