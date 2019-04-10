using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public Vector3 origin;
    public Transform player;
    private Rigidbody rb;
    public bool picked = false;

    private void Start()
    {
        origin = transform.position;
        rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = false;
     
    }


    void Update()
    {
        //If picked is true then....
        if (picked)
        {
            
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