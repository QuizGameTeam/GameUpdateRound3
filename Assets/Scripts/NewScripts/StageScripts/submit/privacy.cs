using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class privacy : MonoBehaviour
    {
        public string input;
        public GameplayScripts game;
        public TMP_InputField Input_Text;
        string ans = "flag{EEe_x_I_FFf}";

        void Start()
        {
            Input_Text.text = "Enter text";
        }

        void Update()
        {
            
        }
        public void ReadStringInput(string s)
        {
            Input_Text.interactable = true;
            
        }
        public void btnSumbit()
        {   
            
            Debug.Log(Input_Text.text);
            Debug.Log(ans);
            if (Input_Text.text == ans) 
            {
                game.GameWin_State();
            }
            else 
            {
                game.GameOver_State();
            }
        }   
    }

}
