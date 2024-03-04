namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();

            // Prompt user to choose a mode: Create/Update Quiz or Play Quiz
            int mode = UserInterface.ChooseMode();

            if (mode == 1)
            {
                // Create/Update Quiz Mode
                int numberOfQuestions = UserInterface.HowManyQuestions();
                List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);
                UserInterface.ReadyToPlayQuiz();

                foreach (var qna in Qnas)
                {
                    var shuffledAnswers = QuizLogic.ShuffleAnswers(qna);
                    bool isCorrect = false;
                    while (!isCorrect)
                    {
                        int userPick = UserInterface.AskAndValidateQuestion(qna, shuffledAnswers);
                        isCorrect = QuizLogic.CheckAnswer(shuffledAnswers, userPick, qna.CorrectAnswer);
                        isCorrect = UserInterface.ProvideFeedback(isCorrect);
                    }
                }

                // Option to save the quiz
                UserInterface.PromptAndSaveQuiz(Qnas);
            }
                else if (mode == 2)
            {
                // Play Mode
                string filePath = UserInterface.AskForQuizFilePath();
                List<QuestionAndAnswers> Qnas = QuestionAndAnswers.LoadQuestionsFromFile(filePath);
                UserInterface.PlayQuiz(Qnas);
            }
        }
    }
}
