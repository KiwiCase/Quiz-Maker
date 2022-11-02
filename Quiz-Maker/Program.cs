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
                Console.WriteLine($"Please confirm your question by pressing ENTER: \n\n{QnAOne.userQuestion}");
                Console.ReadLine();

            }

        }

    }
}

