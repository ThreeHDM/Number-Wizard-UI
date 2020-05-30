using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//agregamos el namespace de textMeshPro
using TMPro;

public class NumberWizard : MonoBehaviour
{
    //Serializamos las variables. Esto hace que pueda ver y manipular los valores de estas variables en la Interfaz de unity
    [SerializeField] int max;
    [SerializeField] int min;

    //Serializamos un campo que permite conectar el guess con el texto de la UI. El type es el tipo de objeto usado en la interface de Unity. En este caso TextMeshProUGUI. Lo llamamos guessText. Al asignar el GuessText Object con el GamePlay Object podemos manipular lo que se muestra en ese texto con exte script
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //Max and min son asignados en el GameObject

        //Inicializamos con un guess definido
        //Aquí es la primera vez que mostramos el texto. Asignamos a la propiedad text de guessText la variable guess convertida a string con ToString()
        NextGuess();
    }

    public void OnPressHigher()
    {
        //sumamos uno para que no adivine un numero que ya mostró
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {   
        //restamos uno para que no adivine un numero que ya mostró
        max = guess - 1;
        NextGuess();
    }

    
    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        //actualizamos lo que mostramos en la Interfaz del juego
        guessText.text = guess.ToString();
    }

}