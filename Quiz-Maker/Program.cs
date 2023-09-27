using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            var Qnas = new List<QuestionAndAnswers>();


            var ordered = Qnas.OrderBy(qbla => qbla.id);

            //QuestionAndAnswers userQnA = UserInterface.UserQuestionsAndAnswers(answer, userQnA);

            UserInterface.ReadyToPlayQuiz();

        }
    }
}

