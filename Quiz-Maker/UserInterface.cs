using static Quiz_Maker.Program;

namespace Quiz_Maker
{
    public static class UserInterface
    {
        private const string ResponseYes = "yes";
        private const string ResponseY = "y";
        /// <summary>
        /// Displays a welcome message to the user.
        /// </summary>
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Casey's Quintessential Quiz Maker");
        }

        /// <summary>
        /// Prompts the user to select between creating a new quiz, loading an existing quiz, or quitting the application.
        /// Continuously requests input until a valid option is entered. Returns the chosen mode or exits the application.
        /// </summary>
        /// <returns>The user's chosen mode as an integer, where 1 represents creating a new quiz, 2 represents loading an existing quiz, and 3 to quit.</returns>
        public static QuizMode ChooseMode()
        {
            Console.WriteLine("Select an option: \n1. Create New Quiz\n2. Load Existing Quiz\n3. Quit");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int mode) && Enum.IsDefined(typeof(QuizMode), mode))
                {
                    return (QuizMode)mode;
                }
                Console.WriteLine("Invalid selection. Please enter 1 to create a new quiz, 2 to load an existing quiz, or 3 to quit.");
            }
        }

        /// <summary>
        /// Prompts the user for the number of questions they want in their quiz.
        /// Uses an infinite loop to validate the input, ensuring it's a valid integer and within the allowed range.
        /// Exits the loop once a valid input is received.
        /// </summary>
        /// <returns>The number of questions the user wants in the quiz, not exceeding the maximum limit.</returns>
        public static int InputNumberOfQuestions()
        {
            const int MaxQuestions = 5; // Constant for maximum allowed questions
            int answer;

            Console.WriteLine($"How many questions would you like in your Quiz? \n{MaxQuestions} is the maximum questions allowed: ");
            while (true) // Infinite loop, exits only when valid input is received
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out answer) && answer > 0 && answer <= MaxQuestions)
                {
                    break; // Exit loop when input is valid and within the allowed range
                }
                // Prompt for input again directly after the if block
                Console.WriteLine($"This is not a valid input. \nHow many questions would you like in your Quiz? \n{MaxQuestions} is the maximum questions allowed: ");
                
            }
            return answer;
        }

        /// <summary>
        /// Prompts the user to input a question and its answers (one correct, three incorrect).
        /// Uses a loop to collect the incorrect answers, improving code maintainability and flexibility.
        /// </summary>
        /// <returns>A QuestionAndAnswers object populated with the user's input.</returns>
        public static QuestionAndAnswers GetQuestionAndAnswers()
        {
            Console.WriteLine("Please type your question: ");
            string userQuestion = Console.ReadLine();

            Console.WriteLine("Please type the correct answer: ");
            string correctAnswer = Console.ReadLine();

            List<string> incorrectAnswers = new();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Please type your {Ordinal(i)} false answer: ");
                string falseAnswer = Console.ReadLine();
                incorrectAnswers.Add(falseAnswer);
            }

            QuestionAndAnswers userQnA = new(userQuestion, correctAnswer);
            userQnA.IncorrectAnswers.AddRange(incorrectAnswers);

            return userQnA;
        }

        /// <summary>
        /// Collects a specified number of questions and their answers from the user.
        /// </summary>
        /// <param name="numberOfQuestions">The number of questions to collect.</param>
        /// <returns>A list of QuestionAndAnswers objects.</returns>
        public static List<QuestionAndAnswers> UserQuestionsAndAnswers(int numberOfQuestions)
        {
            List<QuestionAndAnswers> questionsList = new();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                questionsList.Add(GetQuestionAndAnswers());
            }
            return questionsList;
        }

        /// <summary>
        /// Informs the user that the quiz setup is complete and prompts them to start the quiz.
        /// </summary>
        public static void ReadyToPlayQuiz()
        {
            Console.WriteLine("All set! Press Enter to start the Quiz!");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays the question and the shuffled answer choices.
        /// </summary>
        /// <param name="userQnA">QuestionAndAnswers object containing the question and answers.</param>
        /// <param name="shuffledAnswers">List of shuffled answers.</param>
        public static void DisplayQuestionAndAnswers(QuestionAndAnswers userQnA, List<string> shuffledAnswers)
        {
            Console.WriteLine($"Question: {userQnA.Question}");
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shuffledAnswers[i]}");
            }
        }

        /// <summary>
        /// Validates the user's input and ensures it's within the valid range.
        /// </summary>
        /// <param name="shuffledAnswers">List of shuffled answers for range checking.</param>
        /// <returns>The valid user input as an integer.</returns>
        public static int ValidateUserInput(List<string> shuffledAnswers)
        {
            while (true)
            {
                Console.WriteLine("Pick one answer:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userPick)) // Inline declaration
                {
                    if (userPick > 0 && userPick <= shuffledAnswers.Count)
                    {
                        return userPick;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a number from the list.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }


        /// <summary>
        /// Prompts the user with a question and validates their answer in a loop until a valid answer is provided.
        /// </summary>
        /// <param name="userQnA">The question and answers object.</param>
        /// <param name="shuffledAnswers">The list of shuffled answers.</param>
        /// <returns>The user's selected answer index.</returns>
        public static int AskAndValidateQuestion(QuestionAndAnswers userQnA, List<string> shuffledAnswers)
        {
            while (true)
            {
                DisplayQuestionAndAnswers(userQnA, shuffledAnswers);
                int userPick = ValidateUserInput(shuffledAnswers);
                if (userPick != -1)  // This will always be a valid input
                {
                    return userPick;
                }
            }
        }

        /// <summary>
        /// Converts an integer to its ordinal representation (e.g., 1st, 2nd, 3rd).
        /// </summary>
        /// <param name="number">The number to be converted.</param>
        /// <returns>Ordinal string representation of the number.</returns>
        private static string Ordinal(int number)
        {
            if (number <= 0) return number.ToString();

            int lastTwoDigits = number % 100;
            int lastDigit = number % 10;
            return (lastTwoDigits) switch
            {
                11 or 12 or 13 => number + "th",
                _ => (lastDigit) switch
                {
                    1 => number + "st",
                    2 => number + "nd",
                    3 => number + "rd",
                    _ => number + "th",
                }
            };
        }

        /// <summary>
        /// Displays feedback to the user based on whether their answer was correct or incorrect.
        /// Instead of ending the quiz on an incorrect answer, it allows for repeated attempts.
        /// </summary>
        /// <param name="isCorrect">Indicates whether the user's answer was correct.</param>
        /// <returns>A boolean indicating if the user's answer was correct.</returns>
        public static bool ProvideFeedback(bool isCorrect)
        {
            Console.WriteLine(isCorrect ? "Correct! You have an IQ of 1,000,000 and are a sexy beast lololol" : "Incorrect. Try again loser lololol.");
            return isCorrect;
        }

        /// <summary>
        /// Prompts the user after completing the quiz to see if they want to save their quiz for later use.
        /// If the user chooses to save, they are asked for a file name, and the quiz is saved in JSON format.
        /// </summary>
        /// <param name="Qnas">The list of QuestionAndAnswers objects to save.</param>
        public static void PromptAndSaveQuiz(List<QuestionAndAnswers> Qnas)
        {
            Console.WriteLine("Do you want to save this quiz for later? (yes/no)");
            string saveResponse = Console.ReadLine().Trim().ToLower();
            if (saveResponse == ResponseYes || saveResponse == ResponseY)
            {
                Console.WriteLine("Enter a file name to save your quiz: ");
                string fileName = Console.ReadLine().Trim();
                string filePath = $"{fileName}.json"; // Ensures the file is saved with .json extension

                try
                {
                    // Directly call the SaveQuestionsToFile method from the QuestionAndAnswers class
                    QuizLogic.SaveQuestionsToFile(Qnas, filePath);
                    Console.WriteLine($"Quiz saved successfully to {filePath}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Asks the user for the file path of an existing quiz to play.
        /// </summary>
        /// <returns>The file path of the quiz.</returns>
        public static string AskForQuizFilePath()
        {
            Console.WriteLine("Enter the file path of the quiz you want to play:");
            return Console.ReadLine().Trim();
        }

        /// <summary>
        /// Conducts the quiz by displaying questions and validating user answers.
        /// </summary>
        /// <param name="Qnas">A list of questions and answers loaded from a file.</param>
        public static void PlayQuiz(List<QuestionAndAnswers> Qnas)
        {
            foreach (var qna in Qnas)
            {
                var shuffledAnswers = QuizLogic.ShuffleAnswers(qna);
                bool isCorrect = false;
                while (!isCorrect) // Loop until the correct answer is picked
                {
                    Console.WriteLine($"Question: {qna.Question}");
                    for (int i = 0; i < shuffledAnswers.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {shuffledAnswers[i]}");
                    }

                    int userPick = ValidateUserInput(shuffledAnswers);
                    isCorrect = QuizLogic.CheckAnswer(shuffledAnswers, userPick, qna.CorrectAnswer);
                    ProvideFeedback(isCorrect);
                }
            }
        }

        public static void EditQuiz()
        {
            string filePath = AskForQuizFilePath();
            var Qnas = QuizLogic.LoadQuestionsFromFile(filePath);

            Console.WriteLine("Select a question to edit (or press Enter to skip):");
            for (int i = 0; i < Qnas.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Qnas[i].Question}");
            }
            string input = Console.ReadLine();

            // Check if the user entered a choice to edit a question
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= Qnas.Count)
            {
                // Adjust choice to be zero-based for the index
                choice -= 1;

                // Edit the selected question
                Qnas[choice] = EditQuestion(Qnas[choice]);

                // Save the updated list back to the file
                QuizLogic.SaveQuestionsToFile(Qnas, filePath);
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                // If the user presses Enter without making a choice, skip editing
                Console.WriteLine("No changes made. Skipping to quiz playthrough...");
            }
            else
            {
                Console.WriteLine("Invalid selection. Returning to main menu.");
                return;
            }

            // Offer to play the quiz after editing
            Console.WriteLine("Would you like to play the quiz now? (yes/no)");
            string playQuizResponse = Console.ReadLine().Trim().ToLower();
            if (playQuizResponse == "yes" || playQuizResponse == "y")
            {
                PlayQuiz(Qnas);
            }
        }
       
        private static QuestionAndAnswers EditQuestion(QuestionAndAnswers qna)
        {
            Console.WriteLine("Editing Question: ");
            Console.WriteLine("Current Question: " + qna.Question);
            Console.WriteLine("Enter new question (leave blank to keep current): ");
            string newQuestion = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newQuestion))
            {
                qna.Question = newQuestion; // Ensure Question property has a public setter

                // Edit the correct answer
                Console.WriteLine("Current Correct Answer: " + qna.CorrectAnswer);
                Console.WriteLine("Enter new correct answer (leave blank to keep current): ");
                string newCorrectAnswer = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newCorrectAnswer))
                {
                    qna.CorrectAnswer = newCorrectAnswer;
                }

                // Edit the incorrect answers
                for (int i = 0; i < qna.IncorrectAnswers.Count; i++)
                {
                    Console.WriteLine($"Current Incorrect Answer {i + 1}: {qna.IncorrectAnswers[i]}");
                    Console.WriteLine($"Enter new incorrect answer {i + 1} (leave blank to keep current): ");
                    string newIncorrectAnswer = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newIncorrectAnswer))
                    {
                        qna.IncorrectAnswers[i] = newIncorrectAnswer;
                    }
                }
            }

            return qna;
        }
    }
}
