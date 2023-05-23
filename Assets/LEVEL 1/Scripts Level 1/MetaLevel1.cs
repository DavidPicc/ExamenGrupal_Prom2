using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaLevel1 : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerLevel1"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
