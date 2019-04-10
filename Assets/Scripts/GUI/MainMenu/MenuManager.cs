using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;



public class MenuManager : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
   

    public AudioSource audioS;
    private void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioS.Play();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1;
    }
    public void OK()
    {
       
    }

    public void Play()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }

  

    public void Back()
    {
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
    }

    public void Back2()
    {

        firstPanel.SetActive(true);
       
    }
    
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
