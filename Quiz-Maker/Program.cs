namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            GetQuestionsAndAnswers QandA1 = new GetQuestionsAndAnswers();

            QandA1.askForQuestion = "Please type your question: ";
            QandA1.askForCorrectAnswer = "Please type the correct answer: ";
            QandA1.askForFirstFalseAnswer = "Please type your first false answer: ";
            QandA1.askForSecondFalseAnswer = "Please type your second false answer: ";
            QandA1.askForThirdFalseAnswer = "Please type your third false answer: ";

            Console.WriteLine(QandA1.askForQuestion);
            Console.ReadLine();


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