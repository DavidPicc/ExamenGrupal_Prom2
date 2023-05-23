using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy1 : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 5f;
    public float lifeEnemy1 = 3f;

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();

            Vector3 movement = direction * moveSpeed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletLevel1"))
        {
            lifeEnemy1 -= 1f;
        }
        if (lifeEnemy1 <=0)
        {
            Destroy(gameObject);
        }
    }
}


