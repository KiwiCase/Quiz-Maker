using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    public static class QuizLogic
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Shuffles the answers for a given question and returns the shuffled list along with the index of the correct answer.
        /// This method uses the Fisher-Yates shuffle algorithm for an unbiased shuffle.
        /// </summary>
        /// <param name="userQnA">The question and its answers.</param>
        /// <param name="correctIndex">The index of the correct answer after shuffling.</param>
        /// <returns>A list of shuffled answers.</returns>
        public static List<string> ShuffleAnswers(QuestionAndAnswers userQnA, out int correctIndex)
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

        /// <summary>
        /// Checks if the user's selected answer is correct by comparing it with the correct answer's index.
        /// </summary>
        /// <param name="userPick">The index of the user's selected answer.</param>
        /// <param name="correctIndex">The index of the correct answer.</param>
        /// <returns>True if the user's answer is correct; otherwise, false.</returns>
        public static bool CheckAnswer(int userPick, int correctIndex)
        {
            return userPick - 1 == correctIndex;
        }

        /// <summary>
        /// Facilitates the checking of a user's answer. This method shuffles the answers and then checks if the user's selection is correct.
        /// </summary>
        /// <param name="userQnA">The question and its answers.</param>
        /// <param name="userPick">The index of the user's selected answer.</param>
        /// <returns>True if the user's answer is correct; otherwise, false.</returns>
        public static bool CheckUserAnswer(QuestionAndAnswers userQnA, int userPick)
        {
            int correctIndex;
            List<string> shuffledAnswers = ShuffleAnswers(userQnA, out correctIndex);
            return CheckAnswer(userPick, correctIndex);
        }
    }
}
