using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class ReadInput : MonoBehaviour
    {
        public string input;
        public GameplayScripts game;
        public TMP_InputField Input_Text;
        string ans = "crypto{You_will_be_working_with_hex_strings_a_lot}";

        //[SerializeField] public GameObject PlayerSubmit;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void ReadStringInput(string s)
        {
            Input_Text.interactable = true;
            if (Input_Text.text != null) Debug.Log(Input_Text.text);
           // Input_Text.text() = s;
           // input = s;
            
        //    Debug.Log(PlayerSubmit.GetComponent<InputField>().text);
            
            
        }
        public void btnSumbit()
        {   
            
            Debug.Log(Input_Text.text);
            Debug.Log(ans);
            if (input == ans) 
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
