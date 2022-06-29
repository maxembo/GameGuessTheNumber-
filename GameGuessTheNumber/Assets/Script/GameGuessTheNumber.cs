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
    

    private void Start()
    {
        value = Random.Range(0, 101);
    }

    public void onClick()
    {
        if (inputField.text.Equals(value.ToString()))
            text.text = "Вы угадали!!!";
        else if (Convert.ToInt32(inputField.text) > value)
            text.text = "Загаданное число меньше";
        else if (Convert.ToInt32(inputField.text) < value)
            text.text = "Загаданное число больше";
    }

}
