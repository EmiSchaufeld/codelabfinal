using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    public void Start()
    {
        print("I'm working");
    }



    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);


    }
}
