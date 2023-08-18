
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
        public string NameCharac;
        public string Stage;

        [SerializeField] private GameObject
            vt_TopicPanel,
            vt_CharPanel,
            vt_LoadPanel;
        
        [SerializeField] private AudioSource src;
        [SerializeField] private AudioClip AudioIntro;
        [SerializeField] private AudioClip AudioPlay;

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
            src.clip = AudioIntro;
            src.loop = true;
            src.Play();
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
        public void ChoosePhishing()
        {
            Stage = "Phishing";
        }
        public void ChoosePrivacy()
        {
            Stage = "Privacy";
        }
        public void Load_State()
        {
            Invoke("Game_State", 5.0f);
            SetGameState(GameState.Load);
        }
        public void ChooseJumper()
        {
            NameCharac = "Jumper";
        }
        public void ChooseRunner()
        {
            NameCharac = "Runner";
        }
        public void ChooseFlyer()
        {
            NameCharac = "Flyer";
        }
        public void Game_State()
        {
            
            PlayerPrefs.SetString("name", NameCharac);
            SceneManager.LoadScene(Stage, LoadSceneMode.Single);
        }
        public void GoHome()
        {
            SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        }
    }
}