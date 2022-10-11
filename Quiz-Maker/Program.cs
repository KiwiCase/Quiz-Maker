namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            Question question = new Question();
            question.userQuestion = "";
            question.answerOne = "";
            question.answerTwo = "";
            question.answerThree = "";
            question.correctAnswer = "";

            for (int i = 0; i < answer; i++)
            {
                List<string> firstQuestionAndAnswers = new List<string>();
                string userQuestion = UserInterface.AskQuestion();
                firstQuestionAndAnswers.Add(userQuestion);

                string correctAnswer = UserInterface.AskCorrectAnswer();
                firstQuestionAndAnswers.Add(correctAnswer);

                string answerOne = UserInterface.AskFirstFalseAnswer();
                firstQuestionAndAnswers.Add(answerOne);

                string answerTwo = UserInterface.AskSecondFalseAnswer();
                firstQuestionAndAnswers.Add(answerTwo);

                string answerThree = UserInterface.AskThirdFalseAnswer();
                firstQuestionAndAnswers.Add(answerThree);

            }

        }
    }
}