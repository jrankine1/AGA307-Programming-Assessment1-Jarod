using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : GameBehaviour<UIManager>
{

    public TMP_Text scoreText;
    public TMP_Text timerText;
    public TMP_Text difficultyText;
    
    
    public void UpdateScore(int _score)
    {
        scoreText.text = "Score " + _score;
    }

    public void UpdateTimer(float _timer)
    {
        timerText.text = "Time Remaining: " + _timer.ToString("F2");

        if (_timer < 10f)
            timerText.color = Color.red;
        else
            timerText.color = Color.white;
        
    }

    public void UpdateDifficulty(string _difficulty)
    {
        difficultyText.text = "Difficulty: " + _difficulty;
    }
}
