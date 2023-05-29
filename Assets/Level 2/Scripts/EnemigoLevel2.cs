using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoLevel2 : MonoBehaviour
{
    public float fireRate = 2f; 
    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float bulletSpeed = 10f; 

    private float nextFireTime;

    void Start()
    {
        nextFireTime = Time.time + fireRate;
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Time.time >= nextFireTime)
        {
           
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            bulletRigidbody.velocity = bullet.transform.forward * bulletSpeed;

            nextFireTime = Time.time + fireRate;
        }
    }
}
