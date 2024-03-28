using Newtonsoft.Json;

namespace Quiz_Maker
{
    public class QuestionAndAnswers
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; }
        public int id;

        public QuestionAndAnswers(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new List<string>();

        }
    }
}


