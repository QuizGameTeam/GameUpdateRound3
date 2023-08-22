
// Code for showing health and calculate health and die function

using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UI;

namespace UI
{

    public class HeartCount : MonoBehaviour
    {
        private Text HeartNum;
        public float startingHealth = 3;
        public float currentHealth = 3;

        private GameObject player;
        // private movement movement;
        // private ScoreCount ScoreCount;
        private GameplayScripts GameplayScripts;

        void Start()
        {
            player = GameObject.Find("Player");
            HeartNum = GetComponent<Text>();
            // movement = FindObjectOfType<movement>();
            // ScoreCount = FindObjectOfType<ScoreCount>();
            GameplayScripts = FindObjectOfType<GameplayScripts>();
        }
        void Update()
        {
            // Show heart counter
            HeartNum.text = " X " + currentHealth.ToString() + " / " + startingHealth.ToString();
        }

        // Calculate heart
        public void TakeDamage(float damage)
        {
            // Take damage
            currentHealth = currentHealth - damage;
            if (currentHealth <= 0)
            {
                GameplayScripts.Pause();
                GameplayScripts.OverWithoutSumbit();
                
            }
        }
    }
}
