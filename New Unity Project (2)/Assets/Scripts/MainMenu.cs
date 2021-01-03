using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button Level2B;
    public Button Level3B;
    public Button Level4B;
    int levelComplete;

    // Start is called before the first frame update
    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        Level2B.interactable = false;
        Level3B.interactable = false;
        Level4B.interactable = false;

        switch (levelComplete)
        {
            case 3:
                Level2B.interactable = true;
                break;
            case 4:
                Level2B.interactable = true;
                Level3B.interactable = true;
                break;
            case 5:
                Level2B.interactable = true;
                Level3B.interactable = true;
                Level4B.interactable = true;
                break;
        }


    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);

    }

    public void Reset()
    {
        Level2B.interactable = false;
        Level3B.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void Back()
    {
        SceneManager.LoadScene("Index");
    }

}