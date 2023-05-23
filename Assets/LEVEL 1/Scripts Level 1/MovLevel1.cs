using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovLevel1 : MonoBehaviour
{
    public float speed = 5f;
   

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");


        Vector3 movement = new Vector3(horizontal, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);

        

    }
}
    

