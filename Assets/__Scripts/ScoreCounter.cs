// Author: Austin Morris
// Student ID: 800737964
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    static public ScoreCounter S { get; private set; }

    [Header("Dynamic")]
    public int score = 0;
    public int highScore = 0;

    private Text uiText;

    void Awake()
    {
        S = this;
        // Persist high score across scene reloads using PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Start()
    {
        uiText = GetComponent<Text>();
    }

    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        uiText.text = "Score: " + score.ToString("#,0") + "\nBest: " + highScore.ToString("#,0");
    }
}
