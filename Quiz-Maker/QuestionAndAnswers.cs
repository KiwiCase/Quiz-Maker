
namespace Quiz_Maker
{
    public class QuestionAndAnswers
    {

        public QuestionAndAnswers(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new List<string>();

        }
        public string Question { get; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; }
        public int id;

        static readonly Random ran = new Random();

        //public string GetShuffledAnswers(out int correctIndex)
        //{        
        //    List<string> list = IncorrectAnswers.ToList();
        //    list.Add(CorrectAnswer);
        //    Random ran = new Random();
        //    List<string> shuffled = list.OrderBy(_ => ran.Next()).ToList();  // shuffles list
        //    correctIndex = list.IndexOf(CorrectAnswer);
        //    return list;
        //}

    }

}


