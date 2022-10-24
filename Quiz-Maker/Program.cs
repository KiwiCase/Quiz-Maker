namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            QuestionAndAnswers userQuestionAndAnswers = new QuestionAndAnswers();

            userQuestionAndAnswers.userQuestion = "";
            userQuestionAndAnswers.answerOne = "";
            userQuestionAndAnswers.answerTwo = "";
            userQuestionAndAnswers.answerThree = "";
            userQuestionAndAnswers.correctAnswer = "";

            List<string> QuestionAndAnswers = new List<string>();
            List<QuestionAndAnswers> QuestionAndAnswersExample = new List<QuestionAndAnswers>();

        }
    }
}