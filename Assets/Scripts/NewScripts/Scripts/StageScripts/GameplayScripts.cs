
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UI{

    [Serializable]
    public enum GameState
    {
        UIDisplay,
        Ask,
        Explain,
        Pause,
        GameOver,
        GameWin,
    }
    public class GameplayScripts : MonoBehaviour
    {
        public string name = "Jumper";
        public bool isPaused = false;

        [SerializeField] private GameObject
            vt_UI,
            vt_Ask,
            vt_Explain,
            vt_Pause,
            vt_GameOver,
            vt_GameWin;

        [SerializeField] private AudioSource src;
        [SerializeField] private AudioClip AudioPlay;
        
        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_UI.SetActive(vt_GameState == GameState.UIDisplay);
            vt_Ask.SetActive(vt_GameState == GameState.Ask);
            vt_Explain.SetActive(vt_GameState == GameState.Explain);
            vt_Pause.SetActive(vt_GameState == GameState.Pause);
            vt_GameOver.SetActive(vt_GameState == GameState.GameOver);
            vt_GameWin.SetActive(vt_GameState == GameState.GameWin);
        }

        void Start()
        {
            src.clip = AudioPlay;
            src.loop = true;
            src.Play();
            
            SetGameState(GameState.UIDisplay);

            name = PlayerPrefs.GetString("name");
            if (name == "Jumper")
            {
                GameObject.Find("Flyer").SetActive(false);
                GameObject.Find("Runner").SetActive(false);
            }
            else if (name == "Runner")
            {
                GameObject.Find("Flyer").SetActive(false);
                GameObject.Find("Jumper").SetActive(false);
            }
            else if (name == "Flyer")
            {
                GameObject.Find("Runner").SetActive(false);
                GameObject.Find("Jumper").SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused == true) 
                {
                    UIDisplay_State();
                    UnPause();
                }
                else 
                {
                    Pause_State();
                    Pause();
                }
            }
        }

        // Pause game
        public void Pause()
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        public void UnPause()
        {
            Time.timeScale = 1;
            isPaused = false;
        }

        // State-change function
        public void UIDisplay_State()
        {
            SetGameState(GameState.UIDisplay);
        }
        // State-change function
        public void Ask_State()
        {
            SetGameState(GameState.Ask);
        }
        // State-change function
        public void Explain_State()
        {
            SetGameState(GameState.Explain);
        }
        public void Pause_State()
        {
            SetGameState(GameState.Pause);
        }
        public void GameOver_State()
        {
            SetGameState(GameState.GameOver);
        }
        public void GameWin_State()
        {
            SetGameState(GameState.GameWin);
        }
    }
}