namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();
            QuestionAndAnswers UserQnA = UserInterface.GetQuestionAndAnswers();
          
        }
    }
}