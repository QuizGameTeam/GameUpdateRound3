
// This script works as a main controller that can control
// how this game works, and switch between game states

using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace intro
{
    [Serializable]
    public enum GameState
    {
        Home,
        Credit,
        Learn,
        Quiz,
        Explain,
    }
    public class introManage : MonoBehaviour
    {
        public QuizGameR3 quiz;
        [SerializeField] private AudioSource src;
        [SerializeField] private AudioClip AudioIntro;

        [SerializeField] private GameObject
            vt_HomePanel,
            vt_CreditPanel,
            vt_LearnPanel,
            vt_QuizPanel,
            vt_ExplainPanel;

        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_HomePanel.SetActive(vt_GameState == GameState.Home);
            vt_CreditPanel.SetActive(vt_GameState == GameState.Credit);
            vt_LearnPanel.SetActive(vt_GameState == GameState.Learn);
            vt_QuizPanel.SetActive(vt_GameState == GameState.Quiz);
            vt_ExplainPanel.SetActive(vt_GameState == GameState.Explain);
        }
        // Start is called before the first frame update
        void Awake()
        {
            src.clip = AudioIntro;
            src.loop = true;
            src.Play();
            
            SetGameState(GameState.Home);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitGame();
            }
        }

        public void Home_State()
        {
            SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        }
        public void Credit_State()
        {
            SetGameState(GameState.Credit);
        }
        public void Learn_State()
        {
            SetGameState(GameState.Learn);
        }
        public void Quiz_State()
        {
            SetGameState(GameState.Quiz);
        }
        public void Explain_State()
        {
            SetGameState(GameState.Explain);
        }
        public void ExitGame() 
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit(); // when build game
        }
        public void PlayGame()
        {
            SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        }
    }
}