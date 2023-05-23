using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLevel1 : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;

    private float timer;

    void Start()
    {
        timer = lifetime;
    }

    void Update()
    {
    
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

       
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}


