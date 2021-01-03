using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class choose : MonoBehaviour
{
    // Start is called before the first frame update
    public void Joke()
    {
        SceneManager.LoadScene("Joke");
    }
    public void Choose()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Startik()
    {
        SceneManager.LoadScene("1LevelB");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Syteee()
    {
        Application.OpenURL("https://s2d1ent.github.io");
    }
    public void Discordik()
    {
        Application.OpenURL("https://discord.gg/XTHREBSkXC");
    }
}
