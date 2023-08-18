
// This script works as a main controller that can control
// how this game works, and switch between game states

using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Gameplay{
    [Serializable]
    public enum GameState
    {
        Topic,
        Character,
        Load,
    }
    public class gameManage : MonoBehaviour
    {
        

        [SerializeField] private GameObject
            vt_TopicPanel,
            vt_CharPanel,
            vt_LoadPanel,
            vt_GamePanel;

        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_TopicPanel.SetActive(vt_GameState == GameState.Topic);
            vt_CharPanel.SetActive(vt_GameState == GameState.Character);
            vt_LoadPanel.SetActive(vt_GameState == GameState.Load);
//            vt_GamePanel.SetActive(vt_GameState == GameState.Game);
        }
        void Awake()
        {
            SetGameState(GameState.Topic);
        }

        // State-change function
        public void Topic_State()
        {
            SetGameState(GameState.Topic);
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
        // public void Game_State()
        // {
        //     SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        // }
        public void GoHome()
        {
            SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        }
    }
}