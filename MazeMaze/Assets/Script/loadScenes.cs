using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class loadScenes : MonoBehaviour
{

    public int iLevelToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(iLevelToLoad);

    }


}

