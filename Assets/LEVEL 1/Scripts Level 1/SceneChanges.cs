using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChanges : MonoBehaviour
{
    public Image slider;
    private float timer;
    public float delay = 20f;
    public string sceneName; 

    void Start()
    {
        Invoke("ChangeScene", delay);
        slider.fillAmount = timer / delay;

    }

    private void Update()
    {
       
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }





}


