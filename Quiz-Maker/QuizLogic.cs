using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    public static class QuizLogic
    {
        private static readonly Random random = new Random();

        // Shuffles the answers and returns the shuffled list along with the index of the correct answer.
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

        // Checks if the user's answer is correct.
        public static bool CheckAnswer(int userPick, int correctIndex)
        {
            return userPick - 1 == correctIndex;
        }
    }
}
