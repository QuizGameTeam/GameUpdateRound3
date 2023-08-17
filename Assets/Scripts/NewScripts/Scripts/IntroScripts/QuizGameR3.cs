using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using static UnityEngine.Random;


namespace intro
{
    [Serializable]

    public class QuizGameR3 : MonoBehaviour
    {
        public introManage intro;

        [SerializeField] private TextMeshProUGUI m_TxtQuestion;
        [SerializeField] private TextMeshProUGUI m_TxtAnswerA;
        [SerializeField] private TextMeshProUGUI m_TxtAnswerB;
        [SerializeField] private TextMeshProUGUI m_TxtAnswerC;
        [SerializeField] private TextMeshProUGUI m_TxtAnswerD;

        [SerializeField] private Image m_ImgAnswerA;
        [SerializeField] private Image m_ImgAnswerB;
        [SerializeField] private Image m_ImgAnswerC;
        [SerializeField] private Image m_ImgAnswerD;

        [SerializeField] private Image m_Explain;
        [SerializeField] private TextMeshProUGUI m_TxtExplain;

        [SerializeField] private AudioSource src;
        [SerializeField] private AudioClip WA_ans;
        [SerializeField] private AudioClip AC_ans;


        [SerializeField] public QuesQuiz[] m_QuestionData;

        private int m_QuestionIndex;
        public int randomIndex;

        void Start()
        {
            randomIndex = Range(0, m_QuestionData.Length);
            m_QuestionIndex = randomIndex;
            InitQuestion(randomIndex);
        }
        private void InitQuestion(int pIndex)
        {
            if (pIndex < 0 || pIndex >= m_QuestionData.Length)
                return;

            m_ImgAnswerA.color = Color.white;
            m_ImgAnswerB.color = Color.white;
            m_ImgAnswerC.color = Color.white;
            m_ImgAnswerD.color = Color.white;
        
            m_TxtQuestion.text = m_QuestionData[pIndex].question;
            m_TxtAnswerA.text = "A: " + m_QuestionData[pIndex].answerA;
            m_TxtAnswerB.text = "B: " + m_QuestionData[pIndex].answerB;
            m_TxtAnswerC.text = "C: " + m_QuestionData[pIndex].answerC;
            m_TxtAnswerD.text = "D: " + m_QuestionData[pIndex].answerD;

            m_Explain.color = Color.white;
            m_TxtExplain.text =  m_QuestionData[pIndex].explain;
        }
        public void BtnAnswer_Pressed(string pSelectedAnswer)
        {
            bool flag = false;
            string ans = m_QuestionData[m_QuestionIndex].correctAnswer;
            if (ans == pSelectedAnswer)
            {
                flag = true;
                Debug.Log("Cau tra loi chinh xac");
                src.PlayOneShot(AC_ans);
            }
            else 
            {
                Debug.Log("Ngouuu");
                src.PlayOneShot(WA_ans);
            }
            // display correct ans
            switch (ans)
            {
                case "a":
                    m_ImgAnswerA.color = !flag ? Color.green : Color.red;
                    break;
                case "b":
                    m_ImgAnswerB.color = !flag ? Color.green : Color.red;
                    break;
                case "c":
                    m_ImgAnswerC.color = !flag ? Color.green : Color.red;
                    break;
                case "d":
                    m_ImgAnswerD.color = !flag ? Color.green : Color.red;
                    break;
            }           
            //  user ans
            switch (pSelectedAnswer)
            {
                case "a":
                    m_ImgAnswerA.color = flag ? Color.green : Color.red;
                    break;
                case "b":
                    m_ImgAnswerB.color = flag ? Color.green : Color.red;
                    break;
                case "c":
                    m_ImgAnswerC.color = flag ? Color.green : Color.red;
                    break;
                case "d":
                    m_ImgAnswerD.color = flag ? Color.green : Color.red;
                    break;
            }
            Invoke("Explain", 2f);
        }
        private void Explain()
        {
            intro.SetGameState(GameState.Explain);
            InitQuestion(randomIndex);
            //src.Stop();

        }


        public void Continue_Pressed()
        {
            randomIndex = Range(0, m_QuestionData.Length);
            Debug.Log(randomIndex);
            InitQuestion(randomIndex);
            m_QuestionIndex = randomIndex;
            intro.SetGameState(GameState.Quiz);
            // src.Stop();
            
        }

    }

    
}