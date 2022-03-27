using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameEvents 
{
    public static event Action<GameState> OnGameStateChange = null;

    public static void ReportGameStateChange(GameState _gameState)
    {
        OnGameStateChange?.Invoke(_gameState);
    }
}
