using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NumberClicker : MonoBehaviour
{
    [SerializeField] int maximum;
    [SerializeField] int minimum;
    [SerializeField] Text guessText;

    int guess;

    void Start()
    {
        startGame();
    }

    public void onPressHigher()
    {
        minimum = guess;
        guess = (minimum + maximum) / 2;
        guessText.text = guess.ToString();
    }
    public void onPressLower()
    {
        maximum = guess;
        guess = (minimum + maximum) / 2;
        guessText.text = guess.ToString();
    }
    public void startGame()
    {
        guess = Random.Range(minimum, maximum);
        guessText.text = guess.ToString();
    }
    
}
