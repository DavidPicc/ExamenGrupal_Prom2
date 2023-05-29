using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovLevel1 : MonoBehaviour
{
    public float speed = 5f;
    public string sceneName;


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");


        Vector3 movement = new Vector3(horizontal, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyLevel1"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(sceneName);
        }
    }
}
    

