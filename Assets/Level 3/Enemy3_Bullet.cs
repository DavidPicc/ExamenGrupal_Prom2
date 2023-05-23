using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Wall"))
        {
            // PERDIÓ.
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Level3Manager.instance.bulletsLeft -= 1;
        Level3Manager.instance.UpdateBulletText();
    }
}
