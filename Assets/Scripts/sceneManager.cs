using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    //public float delay = 2;
    //public string newScene = "ARScene";

    //void Start()
    //{
    //    StartCoroutine(LoadLevelAfterDelay(delay));
    //}

    //IEnumerator LoadLevelAfterDelay(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    SceneManager.LoadScene(newScene);
    //}

    public void changeScene(string value)
    {
        SceneManager.LoadScene(value);
    }

}