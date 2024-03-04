namespace Quiz_Maker
{
    public class Program
    {
        public static void Main()
        {
            UserInterface.WelcomeMessage();

            while (true) // Continuously run until the user decides to exit.
            {
                int mode = UserInterface.ChooseMode();

                switch (mode)
                {
                    case 1:
                        // Mode for creating or updating a quiz
                        var numberOfQuestions = UserInterface.HowManyQuestions();
                        var Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);
                        UserInterface.ReadyToPlayQuiz();

                        foreach (var qna in Qnas)
                        {
                            var shuffledAnswers = QuizLogic.ShuffleAnswers(qna);
                            bool isCorrect = false;
                            while (!isCorrect)
                            {
                                var userPick = UserInterface.AskAndValidateQuestion(qna, shuffledAnswers);
                                isCorrect = QuizLogic.CheckAnswer(shuffledAnswers, userPick, qna.CorrectAnswer);
                                UserInterface.ProvideFeedback(isCorrect);
                            }
                        }

                        UserInterface.PromptAndSaveQuiz(Qnas);
                        break;

                    case 2:
                        // Mode for playing a quiz from an existing file
                        var filePath = UserInterface.AskForQuizFilePath();
                        Qnas = QuestionAndAnswers.LoadQuestionsFromFile(filePath);
                        UserInterface.PlayQuiz(Qnas);
                        break;

                    case 3:
                        // Option to exit the application
                        Console.WriteLine("Exiting the application. Thank you for using Quiz Maker.");
                        return; // Exit the Main method, thus ending the program.
                }
            }
        }
    }
}
