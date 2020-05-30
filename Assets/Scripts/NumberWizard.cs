using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Serializamos las variables. Esto hace que pueda ver y manipular los valores de estas variables en la Interfaz de unity
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //Max and min son asignados en el GameObject
        max = max + 1;
        //Inicializamos con un guess definido
        guess = (max + min) / 2;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    
    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}