
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
        ExplainChall,
        ExplainAsk,
        Pause,
        GameOver,
        Continue,
        Sumbit,
        Over_WithoutSumbit,
        GameWin,
    }
    public class GameplayScripts : MonoBehaviour
    {
        public string playerName = "Jumper";
        public bool isPaused = false;

        [SerializeField] private GameObject
            vt_UI,
            vt_Ask,
            vt_ExplainChall,
            vt_ExplainAsk,
            vt_Pause,
            vt_sumbit,
            vt_GameOver,
            vt_Over_WithoutSumbit,
            vt_GameWin;

        [SerializeField] private AudioSource src;
        [SerializeField] private AudioClip AudioPlay;
        
        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_UI.SetActive(vt_GameState == GameState.UIDisplay);
            vt_Ask.SetActive(vt_GameState == GameState.Ask);
            vt_ExplainChall.SetActive(vt_GameState == GameState.ExplainChall);
            vt_ExplainAsk.SetActive(vt_GameState == GameState.ExplainAsk);

            vt_Pause.SetActive(vt_GameState == GameState.Pause);
            vt_GameOver.SetActive(vt_GameState == GameState.GameOver);
            vt_GameWin.SetActive(vt_GameState == GameState.GameWin);
            vt_sumbit.SetActive(vt_GameState == GameState.Sumbit);
            vt_Over_WithoutSumbit.SetActive(vt_GameState == GameState.Over_WithoutSumbit);

        }

        void Start()
        {
            src.clip = AudioPlay;
            src.loop = true;
            src.Play();
            
            
            SetGameState(GameState.UIDisplay);

            playerName = PlayerPrefs.GetString("playerName"); 
            if (playerName == "Jumper")
            {
                GameObject.Find("Flyer").SetActive(false);
                GameObject.Find("Runner").SetActive(false);
            }
            else if (playerName == "Runner")
            {
                GameObject.Find("Flyer").SetActive(false);
                GameObject.Find("Jumper").SetActive(false);
            }
            else if (playerName == "Flyer")
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
        public void OverWithoutSumbit()
        {
            SetGameState(GameState.Over_WithoutSumbit);
        }
        // State-change function
        public void Explain_StateChall()
        {
            SetGameState(GameState.ExplainChall);
        }
        public void Sumbit_ans()
        {
            SetGameState(GameState.Sumbit);
        }
        public void Explain_StateAsk()
        {
            SetGameState(GameState.ExplainAsk);
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
        public void GoHome()
        {
            SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        }
        public void Restartgame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}