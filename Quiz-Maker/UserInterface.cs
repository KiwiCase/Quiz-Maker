using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public static class UserInterface
    {
        /// <summary>
        /// Displays a welcome message to the user.
        /// </summary>
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Casey's Quintessential Quiz Maker");
        }

        /// <summary>
        /// Prompts the user for the number of questions they want in their quiz.
        /// Validates the input to ensure it's a valid integer and within the allowed range.
        /// </summary>
        /// <returns>Number of questions the user wants in the quiz.</returns>
        public static int HowManyQuestions()
        {
            int answer = 0;
            Console.WriteLine("How many questions would you like in your Quiz? \n5 is the maximum questions allowed: ");
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out answer) || answer > 5)
            {
                Console.WriteLine("This is not a valid input. \nHow many questions would you like in your Quiz? \n5 is the maximum questions allowed: ");
                input = Console.ReadLine();
            }
            return answer;
        }

        /// <summary>
        /// Prompts the user to input a question and its answers (one correct, three incorrect).
        /// </summary>
        /// <returns>A QuestionAndAnswers object populated with the user's input.</returns>
        public static QuestionAndAnswers GetQuestionAndAnswers()
        {
            Console.WriteLine("Please type your question: ");
            string userQuestion = Console.ReadLine();

            Console.WriteLine("Please type the correct answer: ");
            string correctAnswer = Console.ReadLine();

            Console.WriteLine("Please type your 1st false answer: ");
            string falseAnswerOne = Console.ReadLine();

            Console.WriteLine("Please type your 2nd false answer: ");
            string falseAnswerTwo = Console.ReadLine();

            Console.WriteLine("Please type your 3rd false answer: ");
            string falseAnswerThree = Console.ReadLine();

            QuestionAndAnswers userQnA = new QuestionAndAnswers(userQuestion, correctAnswer);
            userQnA.IncorrectAnswers.AddRange(new string[] { falseAnswerOne, falseAnswerTwo, falseAnswerThree });

            return userQnA;
        }

        /// <summary>
        /// Collects a specified number of questions and their answers from the user.
        /// </summary>
        /// <param name="numberOfQuestions">The number of questions to collect.</param>
        /// <returns>A list of QuestionAndAnswers objects.</returns>
        public static List<QuestionAndAnswers> UserQuestionsAndAnswers(int numberOfQuestions)
        {
            List<QuestionAndAnswers> questionsList = new List<QuestionAndAnswers>();
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
    }
}
