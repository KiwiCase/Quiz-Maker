using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

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

        }

    }
}

