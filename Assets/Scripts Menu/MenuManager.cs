using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public ClickController Click;
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

