
// This script works as a main controller that can control
// how this game works, and switch between game states

using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

namespace Gameplay{
    [Serializable]
    public enum GameState
    {
        Difficult,
        Character,
        Load,
        Game,
        Ask,
        Finish
    }
    public class gameManage : MonoBehaviour
    {
        

        [SerializeField] private GameObject
            vt_DifficultyPanel,
            vt_CharPanel,
            vt_LoadPanel,
            vt_GamePanel,
            vt_AskPanel,
            vt_FinishPanel;

        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_DifficultyPanel.SetActive(vt_GameState == GameState.Difficult);
            vt_CharPanel.SetActive(vt_GameState == GameState.Character);
            vt_LoadPanel.SetActive(vt_GameState == GameState.Load);
            vt_GamePanel.SetActive(vt_GameState == GameState.Game);
            vt_AskPanel.SetActive(vt_GameState == GameState.Ask);
            vt_FinishPanel.SetActive(vt_GameState == GameState.Finish);
        }
        void Awake()
        {
            SetGameState(GameState.Difficult);
        }

        // State-change function
        public void Difficulty_State()
        {
            SetGameState(GameState.Difficult);
        }
        public void Character_State()
        {
            SetGameState(GameState.Character);
        }
        public void Load_State()
        {
            Invoke("Game_State", 5.0f);
            SetGameState(GameState.Load);
        }
        public void Game_State()
        {
            SetGameState(GameState.Game);
        }
        public void Ask_State()
        {
            SetGameState(GameState.Ask);
        }
        public void Finish_State()
        {
            SetGameState(GameState.Finish);
        }
    }
}