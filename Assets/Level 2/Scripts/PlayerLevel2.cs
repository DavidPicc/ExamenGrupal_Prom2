using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel2 : MonoBehaviour
{
    public float speed = 5f; // velocidad del jugador

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveForward = Input.GetAxis("Vertical");

        // Movimiento horizontal (izquierda y derecha)
        Vector3 horizontalMovement = new Vector3(moveHorizontal, 0f, 0f);
        transform.Translate(horizontalMovement * speed * Time.deltaTime);

        // Movimiento hacia adelante
        if (moveForward > 0f)
        {
            Vector3 forwardMovement = new Vector3(0f, 0f, moveForward);
            transform.Translate(forwardMovement * speed * Time.deltaTime);
        }
    }
}
