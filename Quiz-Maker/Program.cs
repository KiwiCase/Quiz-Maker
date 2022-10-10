namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            Question firstQuestion = new Question();
            firstQuestion.userQuestion = "";
            firstQuestion.answerOne = "";
            firstQuestion.answerTwo = "";
            firstQuestion.answerThree = "";
            firstQuestion.correctAnswer = "";

            if (answer == 1)
            {
                UserInterface.AskQuestion();
                UserInterface.AskCorrectAnswer();

            }

        }
    }
}