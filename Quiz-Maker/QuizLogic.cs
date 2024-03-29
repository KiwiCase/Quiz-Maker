using Newtonsoft.Json;

namespace Quiz_Maker
{
    public static class QuizLogic
    {
        private static readonly Random random = new();

        /// <summary>
        /// Shuffles the answers for a given question and returns the shuffled list.
        /// This method uses the Fisher-Yates shuffle algorithm for an unbiased shuffle.
        /// </summary>
        /// <param name="userQnA">The question and its answers.</param>
        /// <returns>A list of shuffled answers.</returns>
        public static List<string> ShuffleAnswers(QuestionAndAnswers userQnA)
        {
            List<string> answers = new(userQnA.IncorrectAnswers) { userQnA.CorrectAnswer };
            int n = answers.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (answers[j], answers[i]) = (answers[i], answers[j]);
            }
            return answers;
        }

        /// <summary>
        /// Checks if the user's selected answer is correct by comparing it with the correct answer's index.
        /// </summary>
        /// <param name="shuffledAnswers">The list of shuffled answers.</param>
        /// <param name="userPick">The index of the user's selected answer.</param>
        /// <param name="correctAnswer">The correct answer text.</param>
        /// <returns>True if the user's answer is correct; otherwise, false.</returns>
        public static bool CheckAnswer(List<string> shuffledAnswers, int userPick, string correctAnswer)
        {
            int correctIndex = shuffledAnswers.IndexOf(correctAnswer);
            return userPick - 1 == correctIndex;
        }

        public static void SaveQuestionsToFile(List<QuestionAndAnswers> questions, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(questions, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public static List<QuestionAndAnswers> LoadQuestionsFromFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<QuestionAndAnswers>>(jsonString);
        }
    }
}