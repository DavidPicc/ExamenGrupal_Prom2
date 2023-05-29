using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletEnemy2 : MonoBehaviour
{
    public string sceneName;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(sceneName);
        }
    }
}
