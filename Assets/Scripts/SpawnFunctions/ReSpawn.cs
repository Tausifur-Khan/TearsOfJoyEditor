using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public Vector3 origin;
    public float delaySpawn = 0.5f;
    public PickUp pick;


    private void Start()
    {
        pick = GetComponent<PickUp>();
        origin = transform.position;
    }
    IEnumerator SpawnTime()
    {

        pick.picked = false;
        yield return new WaitForSeconds(delaySpawn);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "KillZone")
        {
            StartCoroutine("SpawnTime");
        }
    }

}
