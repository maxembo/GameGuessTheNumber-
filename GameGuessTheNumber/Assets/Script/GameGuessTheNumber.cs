using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameGuessTheNumber : MonoBehaviour
{
    public Text text;
    public InputField inputField;
    private int value = 0;
    public GameObject image;
    public GameObject currentImage;
    public GameObject startGame;
    

    private void Start()
    {
        value = Random.Range(0, 101);
    }

    public void onClick()
    {
        
        if (Convert.ToInt32(inputField.text) > value)
            text.text = "Загаданное число меньше";
        else if (Convert.ToInt32(inputField.text) < value)
            text.text = "Загаданное число больше";
        else if (inputField.text.Equals(value.ToString()))
        {
            text.text = "Вы угадали!!! Хотите еще поиграть?";
            
        }
            
    }
}
