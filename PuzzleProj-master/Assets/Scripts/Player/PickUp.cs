using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    public bool picked = false;
   

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }


    void Update()
    {
        //If picked is true then....
        if (picked)
        {
            Debug.Log(picked);
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(player);
           
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.SetParent(null);
        }

    }
}