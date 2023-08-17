using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace intro
{
    
    [CreateAssetMenu(fileName = "Ques", menuName = "quizz/Ques", order = 0)]
    public class QuesQuiz : ScriptableObject
    {
        public string question;
        public string answerA;
        public string answerB;
        public string answerC;
        public string answerD;
        public string explain;
        public string correctAnswer;   
    }
}

