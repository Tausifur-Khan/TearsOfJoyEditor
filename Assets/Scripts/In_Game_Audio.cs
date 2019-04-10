using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Game_Audio : MonoBehaviour
{
    public AudioSource audioS;
    // Use this for initialization
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioS.Play();
    }

}
