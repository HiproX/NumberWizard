using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    int maxGuessesAllowed = 10;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        --maxGuessesAllowed;
        text.text = guess.ToString();
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
}
