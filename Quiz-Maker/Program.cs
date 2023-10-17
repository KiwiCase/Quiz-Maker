using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Display a welcome message to the user.
            UserInterface.WelcomeMessage();

            // Ask the user how many questions they'd like to add to the quiz.
            int numberOfQuestions = UserInterface.HowManyQuestions();

            // Gather the questions and their respective answers from the user
            // and store them in the Qnas list.
            List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);

            // Inform the user that the setup is complete and prompt them to start the quiz.
            UserInterface.ReadyToPlayQuiz();
        }
    }
}

