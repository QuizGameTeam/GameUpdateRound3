using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UI
{
    public class link : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        // Learn
        public void chall_pic()
        {
            Application.OpenURL("https://drive.google.com/file/d/1w87JhhYweTcI2aGhGMbW3aW6Nj7Na5nO/view");
        }
        public void sol_quiz()
        {
            Application.OpenURL("https://docs.google.com/document/d/1BwTzjrXOj9j7vF1FdHaVXtoT3aFtrP3kcTf4Hzza7yQ/edit?usp=sharing");
        }
        public void sol_chall()
        {
            Application.OpenURL("https://exiftool.org/");
        }
        public void link_hint()
        {
            Application.OpenURL("https://exiftool.org/");
        }
    }


}
