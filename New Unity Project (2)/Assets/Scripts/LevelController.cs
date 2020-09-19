﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    int levelComplete;


    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;

        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }


    public void isEndGame()
    {
        if (sceneIndex == 3)
        {
            Invoke("MainMenu", 1f);
        }
        else
        {
            if (levelComplete < sceneIndex)
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("Smoke", 1f);
        }
    }

    void Smoke()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
