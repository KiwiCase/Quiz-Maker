namespace Quiz_Maker
{
    public class Program
    {
        public enum QuizMode
        {
            CreateNewQuiz = 1,
            LoadExistingQuiz = 2,
            Quit = 3
        }

        public static void Main()
        {
            UserInterface.WelcomeMessage();

            while (true)
            {
                QuizMode mode = UserInterface.ChooseMode();

                switch (mode)
                {
                    case QuizMode.CreateNewQuiz:
                        // Logic for creating a new quiz
                        break;

                    case QuizMode.LoadExistingQuiz:
                        // Logic for loading an existing quiz
                        UserInterface.EditQuiz();
                        break;

                    case QuizMode.Quit:
                        Console.WriteLine("Exiting the application. Thank you for using Quiz Maker.");
                        return; // Cleanly exits the program.
                }
            }
        }
    }
}
