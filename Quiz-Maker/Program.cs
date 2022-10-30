using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            if (answer > 0)
            {
                QuestionAndAnswers QnAOne = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine(QnAOne);
            }

            if (answer > 1)
            {
                QuestionAndAnswers QnATwo = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine(QnATwo);
            }

            if (answer > 2)
            {
                QuestionAndAnswers QnAThree = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine(QnAThree);
            }

            if (answer > 3)
            {
                QuestionAndAnswers QnAFour = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine(QnAFour);
            }

            if (answer > 4)
            {
                QuestionAndAnswers QnAFive = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine(QnAFive);
            }
        }

    }
}
