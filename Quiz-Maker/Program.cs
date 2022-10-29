namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            if (answer < 6)
            {
                QuestionAndAnswers QnAOne = UserInterface.GetQuestionAndAnswers();
            }

            if (answer < 5)
            {
                QuestionAndAnswers QnATwo = UserInterface.GetQuestionAndAnswers();
            }

            if (answer < 4)
            {
                QuestionAndAnswers QnAThree = UserInterface.GetQuestionAndAnswers();
            }

            if (answer < 3)
            {
                QuestionAndAnswers QnAFour = UserInterface.GetQuestionAndAnswers();
            }

            if (answer < 2)
            {
                QuestionAndAnswers QnAFive = UserInterface.GetQuestionAndAnswers();
            }
        }
    }
}