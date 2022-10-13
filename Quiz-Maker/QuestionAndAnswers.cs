using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public class QuestionAndAnswers
    {
        public string userQuestion;
        public string answerOne;
        public string answerTwo;
        public string answerThree;
        public string correctAnswer;

        public QuestionAndAnswers() { }
        public QuestionAndAnswers(string userQuestion, string answerOne, string answerTwo, string answerThree, string correctAnswer)
        {
            this.userQuestion = userQuestion;
            this.answerOne = answerOne;
            this.answerTwo = answerTwo;
            this.answerThree = answerThree;
            this.correctAnswer = correctAnswer;
        }
    }

}

