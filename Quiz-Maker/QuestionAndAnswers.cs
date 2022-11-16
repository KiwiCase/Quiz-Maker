using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public class QuestionAndAnswers

    {
        private readonly string _correctAnswer;

        public QuestionAndAnswers(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new List<string>();
        }
        public string Question { get; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; }

        static readonly Random rng = new Random();
        public string[] GetShuffledAnswers(out int correctIndex)
        {
            var list = IncorrectAnswers.ToList();
            list.Add(CorrectAnswer);
            list.Sort((x, y) => rng.Next(2) * 2 - 1);   // shuffles list
            correctIndex = list.IndexOf(CorrectAnswer);
            return list.ToArray();
        }

    }

}


