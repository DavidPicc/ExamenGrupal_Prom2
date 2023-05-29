using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Distancias : MonoBehaviour
{
    public Transform startPoint;
    public TextMeshProUGUI distanceText; 

    private float distanceTraveled;

    void Start()
    {
        distanceTraveled = 0f;
    }

    void Update()
    {
        // Calcula la distancia entre el punto de inicio y la posición actual del jugador
        distanceTraveled = Vector3.Distance(startPoint.position, transform.position);

        // Actualiza el texto con la distancia recorrida
        distanceText.text = "Distancia: " + distanceTraveled.ToString("F2");
    }
}
