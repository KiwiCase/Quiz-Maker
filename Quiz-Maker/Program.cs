using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    public class Program
    {
        private static readonly Random random = new Random(); // Static Random instance

        // Entry point of the program.
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int numberOfQuestions = UserInterface.HowManyQuestions();
            List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);
            UserInterface.ReadyToPlayQuiz();
            foreach (var qna in Qnas)
            {
                AskQuestion(qna);
            }
        }

        /// <summary>
        /// Handles the process of asking a question, including shuffling answers and checking the user's input.
        /// </summary>
        /// <param name="userQnA">QuestionAndAnswers object containing the question and answers.</param>
        public static void AskQuestion(QuestionAndAnswers userQnA)
        {
            int correctIndex;
            List<string> shuffledAnswers = ShuffleAnswers(userQnA, out correctIndex);
            bool isCorrect = false;

            while (!isCorrect)
            {
                UserInterface.DisplayQuestionAndAnswers(userQnA, shuffledAnswers);
                int userPick = UserInterface.ValidateUserInput(shuffledAnswers);
                isCorrect = CheckAnswer(userPick, correctIndex);
            }
        }

        // Shuffles the answers and returns the shuffled list along with the index of the correct answer.
        private static List<string> ShuffleAnswers(QuestionAndAnswers userQnA, out int correctIndex)
        {
            List<string> answers = new List<string>(userQnA.IncorrectAnswers);
            answers.Add(userQnA.CorrectAnswer);
            int n = answers.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (answers[j], answers[i]) = (answers[i], answers[j]);
            }
            correctIndex = answers.IndexOf(userQnA.CorrectAnswer);
            return answers;
        }

        // Checks if the user's answer is correct.
        private static bool CheckAnswer(int userPick, int correctIndex)
        {
            return userPick - 1 == correctIndex;
        }
    }
}
