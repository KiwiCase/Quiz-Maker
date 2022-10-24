namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();
            

            //consolidate methods into 1 method gaaaaaah XD

            GetQuestionsAndAnswers askQuestionAndAnswers = new GetQuestionsAndAnswers();

            askQuestionAndAnswers.askForQuestion = "Please type your question: ";
            askQuestionAndAnswers.askForCorrectAnswer = "Please type the correct answer: ";
            askQuestionAndAnswers.askForFirstFalseAnswer = "Please type your first false answer: ";
            askQuestionAndAnswers.askForSecondFalseAnswer = "Please type your second false answer: ";
            askQuestionAndAnswers.askForThirdFalseAnswer = "Please type your third false answer: ";

            Console.WriteLine(askQuestionAndAnswers.askForQuestion);
            string userQuestion = Console.ReadLine();

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