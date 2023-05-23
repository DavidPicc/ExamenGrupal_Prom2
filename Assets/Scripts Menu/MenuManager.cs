using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    [SerializeField]
    private  List<LevelController> Levels;
    private void Awake()
    {
        instance = this;
         foreach(var Levels in Levels)
        {
            Levels.levelButton.onClick.AddListener(() => Levels.LoadLevel());
        }
       

    }
    public static MenuManager getInstance()
    {
        return instance;
    }
    
  
}

