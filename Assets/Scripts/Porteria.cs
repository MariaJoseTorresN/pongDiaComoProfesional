using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteria : MonoBehaviour
{
    public bool jugador1Punto;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Balon"))
        {
            if (jugador1Punto)
            {
                gameManager.GetComponent<GameManager>().Jugador1Puntaje();
            }
            else
            {
                gameManager.GetComponent<GameManager>().Jugador2Puntaje();
            }
        }
    }
}
