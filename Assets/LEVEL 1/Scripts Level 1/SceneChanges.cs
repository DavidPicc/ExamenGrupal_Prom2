using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChanges : MonoBehaviour
{
    public string sceneName; 
    public float delay = 20f; 
    public Image timeBar; 
   

    private float currentTime = 0f;
    private float totalTime = 0f; 

    void Start()
    {
        totalTime = delay;

     
        UpdateTime();
    }

    void Update()
    {
        currentTime += Time.deltaTime;

       
        UpdateTime();

        if (currentTime >= delay)
        {
            ChangeScene();
        }
    }

    void UpdateTime()
    {
        float remainingTime = delay - currentTime;

        float fillAmount = currentTime / totalTime;
        timeBar.fillAmount = fillAmount;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }




}


