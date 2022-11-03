using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            for (int i = 0; i < answer; i++)
            { 
            QuestionAndAnswers QnAOne = UserInterface.GetQuestionAndAnswers();

                if (answer > 0)
                {
                    Console.WriteLine(QnAOne);

                    if (answer > 1)
                    {
                        Console.WriteLine(QnAOne);
                    }
                }
            }

        }
    }
}

