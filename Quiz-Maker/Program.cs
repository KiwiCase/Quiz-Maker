using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {
        private static QuestionAndAnswers userQnA;

        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            QuestionAndAnswers UserQnA = UserInterface.UserQuestionsAndAnswers(answer, userQnA);

            UserInterface.ReadyToPlayQuiz();
            UserInterface.AskQuestion(userQnA);

        }
    }
}

