using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{


    //public GameObject daruma1;
    //public GameObject daruma2;
    //public GameObject daruma3;

    public Transform start;
    public Transform end;
    public float MoveTime;
    public float moveDelay;
    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 currentPos = Vector3.Lerp(start.position, end.position, Mathf.Cos(Time.time / MoveTime * Mathf.PI * 2) * -.5f + .5f);
        //Move Platform
        transform.position = currentPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == " Daruma")
        {
            other.transform.parent = transform;
        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player" || other.tag == " Daruma")
        {
            other.transform.parent = null;
        }

    }
}
