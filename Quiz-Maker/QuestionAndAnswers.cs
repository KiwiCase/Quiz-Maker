
using Newtonsoft.Json;

namespace Quiz_Maker
{
    public class QuestionAndAnswers
    {
        public string Question { get; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; }
        public int id;

        public QuestionAndAnswers(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new List<string>();

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


