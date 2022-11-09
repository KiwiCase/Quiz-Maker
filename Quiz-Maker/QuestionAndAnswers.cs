using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public class QuestionAndAnswers
    {
        List<string> QnAList = new List<string>();
        public string userQuestion;
        public string falseAnswerOne;                 //TODO: this could maybe perhaps possilby be a list of string
        public string falseAnswerTwo;                 //TODO: this could maybe perhaps possilby be a list of string
        public string falseAnswerThree;               //TODO: this could maybe perhaps possilby be a list of string
        public string correctAnswer;

        
        private int correctAnswerIndex;//TODO: this could maybe perhaps possilby be a list of string

        public override string ToString()
        {
            return userQuestion;
        }

    }
}

