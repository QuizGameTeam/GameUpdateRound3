
// This script works as a main controller that can control
// how this game works, and switch between game states

using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class gameManage : MonoBehaviour
{
    public enum GameState
    {
        Game,
        Ask,
        GameWin,
        GameOver
    }

    [SerializeField] private GameObject
        vt_GamePanel,
        vt_AskPanel,
        vt_GameWinPanel,
        vt_GameOverPanel;

    private GameState vt_GameState;
    public void SetGameState(GameState state)
    {
        vt_GameState = state;
        vt_GamePanel.SetActive(vt_GameState == GameState.Game);
        vt_AskPanel.SetActive(vt_GameState == GameState.Ask);
        vt_GameWinPanel.SetActive(vt_GameState == GameState.GameWin);
        vt_GameOverPanel.SetActive(vt_GameState == GameState.GameOver);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        SetGameState(GameState.Home);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // State-change function
    public void Game_State()
    {
        SetGameState(GameState.Game);
    }
    public void Ask_State()
    {
        SetGameState(GameState.Ask);
    }
    public void GameWin_State()
    {
        SetGameState(GameState.GameWin);
    }
    public void GameOver_State()
    {
        SetGameState(GameState.GameOver);
    }
}
