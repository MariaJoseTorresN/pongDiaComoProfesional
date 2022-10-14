using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject balon;
    
    public GameObject jugador1;
    public GameObject porteriaJugador1;

    public GameObject jugador2;
    public GameObject porteriaJugador2;

    public TextMeshProUGUI jugador1Text;
    public TextMeshProUGUI jugador2Text;

    private int jugador1Puntaje;
    private int jugador2Puntaje;

    public void Jugador1Puntaje()
    {
        jugador1Puntaje++;
        jugador1Text.text = jugador1Puntaje.ToString();
        ResetPosition();
    }

    public void Jugador2Puntaje()
    {
        jugador2Puntaje++;
        jugador2Text.text = jugador2Puntaje.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        balon.GetComponent<Balon>().Reset();
        jugador1.GetComponent<Players>().Reset();
        jugador2.GetComponent<Players>().Reset();
    }
}
