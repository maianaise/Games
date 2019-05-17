using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int maximum = 500;
    int minimum = 1;
    int guess = 250;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number wizard");
        Debug.Log("Pick a number:");
        Debug.Log("High end is 500, low end is 1");
        Debug.Log("Up = higher, Down is lower, enter is correct");
        guess = 250;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            minimum = guess;
            guess = (minimum + maximum) / 2;
            Debug.Log("Is your guess " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            maximum = guess;
            guess = (minimum + maximum) / 2;
            Debug.Log("Is your guess " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yay!");
            StartGame();
        }
    }
}
