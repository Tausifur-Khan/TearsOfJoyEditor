using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadScreen;
    public Slider slider;

    AsyncOperation async;

    public void LoadScreen(int lvl)
    {
        StartCoroutine(LoadingSceneSetup(lvl));
    }

    IEnumerator LoadingSceneSetup(int lvl)
    {
        //Activate loading screen menu 
        loadScreen.SetActive(true);
        //Set async operation to load new scene
        async = SceneManager.LoadSceneAsync(lvl);
        //Scene activation is false
        async.allowSceneActivation = false;

        //Set while loop condition for scene activation
        //While loop -> is the loading process finished?
        while (async.isDone == false)
        {
            //Sliders value is equal to scene load progress
            slider.value = async.progress;
            //if operations progress reaches 90% then...
            if (async.progress == 0.9f)
            {
                //Slider value is equal to max slider value
                slider.value = 1f;
                //Allow operation to commence scene change
                async.allowSceneActivation = true;
            }
            yield return null;
        }


    }

}
