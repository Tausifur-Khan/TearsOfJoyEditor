using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLvl : MonoBehaviour
{
    public float delay = 2f;
    public string ChooseLvl;
    IEnumerator WaitBeforeLoad()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(ChooseLvl);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Daruma")
        {
            StartCoroutine("WaitBeforeLoad");          
        }
    }

}
