using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLvl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Daruma")
        {
            SceneManager.LoadScene(0);
        }
    }

}
