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
                List<string> questionAndAnswers = new List<string>();
                string userQuestion = UserInterface.AskQuestion();
                questionAndAnswers.Add(userQuestion);

                string correctAnswer = UserInterface.AskCorrectAnswer();
                questionAndAnswers.Add(correctAnswer);

                string answerOne = UserInterface.AskFirstFalseAnswer();
                questionAndAnswers.Add(answerOne);

                string answerTwo = UserInterface.AskSecondFalseAnswer();
                questionAndAnswers.Add(answerTwo);

                string answerThree = UserInterface.AskThirdFalseAnswer();
                questionAndAnswers.Add(answerThree);

            }

        }
    }
}