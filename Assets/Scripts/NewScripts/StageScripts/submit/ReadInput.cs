using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class ReadInput : MonoBehaviour
    {
        public GameplayScripts game;
        public TMP_InputField Input_Text;
        string ans = "crypto{You_will_be_working_with_hex_strings_a_lot}";
        
        void Start()
        {
            Input_Text.text = "Enter text";
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void ReadStringInput(string s)
        {
            Input_Text.interactable = true;
            //if (Input_Text.text != null) Debug.Log(Input_Text.text);
            
        }
        public void btnSumbit()
        {   
            if (Input_Text.text == "Enter text") game.OverWithoutSumbit();
            else 
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

}
