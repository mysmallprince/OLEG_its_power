﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class joke : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Joke");
    }
}
