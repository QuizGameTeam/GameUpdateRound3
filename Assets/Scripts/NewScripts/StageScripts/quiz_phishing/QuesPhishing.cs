using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI
{
    
    [CreateAssetMenu(fileName = "phishing", menuName = "quizz/phisng", order = 0)]
    public class QuesPhishing : ScriptableObject
    {
        public string question;
        public string answerA;
        public string answerB;
        public string answerC;
        public string answerD;
        public string correctAnswer;
    }
}

