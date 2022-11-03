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
                Console.WriteLine($"Thank you for your question and answers - they are as follows:\n\nQuiz Question 1 - {QnAOne.userQuestion}\nCorrect Answer - {QnAOne.correctAnswer}\nFalse Answer 1 - {QnAOne.falseAnswerOne}\nFalse Answer 2 - {QnAOne.falseAnswerTwo}\nFalse Answer 3 - {QnAOne.falseAnswerThree}");
                Console.ReadLine();

            }

            /*if (answer > 1)
            {
                QuestionAndAnswers QnATwo = UserInterface.GetQuestionAndAnswers(); //In response to Issue 4 in GH
            }*/

        }

    }
}

