using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Display a welcome message to the user.
            UserInterface.WelcomeMessage();

            // Ask the user how many questions they'd like to add to the quiz.
            int numberOfQuestions = UserInterface.HowManyQuestions();

            // Gather the questions and their respective answers from the user
            // and store them in the Qnas list.
            List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);

            // Inform the user that the setup is complete and prompt them to start the quiz.
            UserInterface.ReadyToPlayQuiz();

            // Call the AskQuestion method using the UserInterface prefix.
            foreach (var qna in Qnas)
            {
                AskQuestion(qna);
            }
        }

        /// <summary>
        /// Displays a question to the user and checks their answer.
        /// </summary>
        /// <param name="userQnA">The QuestionAndAnswers object representing the question.</param>
        /// <returns>True if the user's answer is correct, false otherwise.</returns>
        public static bool AskQuestion(QuestionAndAnswers userQnA)
        {
            // Shuffle the answer choices and get the correct answer's index.
            int correctIndex;
            List<string> shuffledAnswers = UserInterface.ShuffleAnswers(userQnA, out correctIndex);

            Console.WriteLine($"Question: {userQnA.Question}");

            // Display shuffled answer choices to the user.
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shuffledAnswers[i]}");
            }

            int userPick = 0;
            do
            {
                Console.WriteLine("Pick one answer:");
                string input = Console.ReadLine();
                int.TryParse(input, out userPick);
            } while (userPick <= 0 || userPick > shuffledAnswers.Count);

            // Check if the user's answer is correct.
            bool isCorrect = userPick - 1 == correctIndex;

            if (isCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is: {shuffledAnswers[correctIndex]}");
            }

            return isCorrect;
        }

    }
}

