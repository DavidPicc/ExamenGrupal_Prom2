using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[Serializable]
public class LevelController 
{
    [SerializeField]
    private Button ButtonLevel;
    [SerializeField]
    private int Nivel;

    public Button levelButton
    {
        get{ return ButtonLevel; }
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level" + Nivel);
    }
}

