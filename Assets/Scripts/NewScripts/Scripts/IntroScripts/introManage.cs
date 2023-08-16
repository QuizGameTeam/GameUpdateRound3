
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
        Option,
        Credit,
        Learn,
        Test,
    }
    public class introManage : MonoBehaviour
    {

        [SerializeField] private GameObject
            vt_HomePanel,
            vt_OptionPanel,
            vt_CreditPanel,
            vt_LearnPanel,
            vt_TestPanel;

        private GameState vt_GameState;
        public void SetGameState(GameState state)
        {
            vt_GameState = state;
            vt_HomePanel.SetActive(vt_GameState == GameState.Home);
            vt_OptionPanel.SetActive(vt_GameState == GameState.Option);
            vt_CreditPanel.SetActive(vt_GameState == GameState.Credit);
            vt_LearnPanel.SetActive(vt_GameState == GameState.Learn);
            vt_TestPanel.SetActive(vt_GameState == GameState.Test);
        }
        // Start is called before the first frame update
        void Awake()
        {
            SetGameState(GameState.Home);
        }

        // State-change function
        public void Home_State()
        {
            SetGameState(GameState.Home);
        }
        public void Option_State()
        {
            SetGameState(GameState.Option);
        }
        public void Credit_State()
        {
            SetGameState(GameState.Credit);
        }
        public void Learn_State()
        {
            SetGameState(GameState.Learn);
        }
        public void Test_State()
        {
            SetGameState(GameState.Test);
        }
        public void PlayGame()
        {
            SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        }
    }
}