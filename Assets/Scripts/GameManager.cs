using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Playing, Paused, Title, GameOver}
public enum Difficulty { Easy, Medium, Hard}
public class GameManager : GameBehaviour<GameManager>
{
    public int score = 0;
    public float maxTime = 30;
    float timer = 30;
    public GameState gameState;

    public void AddScore(int _points)
    {
        score += _points;
        _UI.UpdateScore(score);
    }

    void AddTimer(float _timer)
    {
        timer += _timer;
        _UI.UpdateTimer(timer);
    }
    private void Update()
    {
        if (gameState == GameState.Playing)
        {
            timer -= Time.deltaTime;
            timer = Mathf.Clamp(timer, 0, maxTime);
            _UI.UpdateTimer(timer);
        }
    }

    public void ChangeGameState(GameState _gameState)
    {
        gameState = _gameState;
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
