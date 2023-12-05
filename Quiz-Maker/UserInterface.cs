using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public static class UserInterface
    {
        /// Displays a welcome message to the user.
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Casey's Quintessential Quiz Maker");
        }

        /// <summary>
        /// Asks the user for the number of questions they'd like in their quiz.
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
        /// Prompts the user to input a question, its correct answer, and three incorrect answers.
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
        /// Collects a series of questions and their respective answers from the user based on the given count.
        /// </summary>
        /// <param name="answer">The number of questions to be collected from the user.</param>
        /// <param name="userQnA">An instance of QuestionAndAnswers to be populated.</param>
        /// <returns>The last QuestionAndAnswers object populated with the user's input.</returns>
        public static QuestionAndAnswers UserQuestionsAndAnswers(int answer, QuestionAndAnswers userQnA)
        {
            for (int i = 0; i < answer; i++)
            {
                userQnA = UserInterface.GetQuestionAndAnswers();
            }
            return userQnA;
        }

        /// <summary>
        /// Informs the user that the setup is complete and prompts them to start the quiz.
        /// </summary>
        public static void ReadyToPlayQuiz()
        {
            Console.WriteLine("All set! Press Enter to start the Quiz!");
            Console.ReadKey();
        }

        public static List<QuestionAndAnswers> UserQuestionsAndAnswers(int answer)
        {
            // Create a list to store the questions and their respective answers.
            List<QuestionAndAnswers> questionsList = new List<QuestionAndAnswers>();

            // Loop based on the number of questions the user wants to add.
            for (int i = 0; i < answer; i++)
            {
                // Prompt the user to input a question, correct answer, and three incorrect answers.
                // Then store the result in the userQnA object.
                QuestionAndAnswers userQnA = UserInterface.GetQuestionAndAnswers();

                // Add the collected question and answers to the list.
                questionsList.Add(userQnA);
            }

            // Return the list of questions and answers.
            return questionsList;
        }

        /// <summary>
        /// Shuffles the answer choices for a question and returns the shuffled list along with the index of the correct answer.
        /// </summary>
        /// <param name="userQnA">The QuestionAndAnswers object representing the question.</param>
        /// <param name="correctIndex">Out parameter to store the index of the correct answer in the shuffled list.</param>
        /// <returns>The shuffled list of answer choices.</returns>
        public static List<string> ShuffleAnswers(QuestionAndAnswers userQnA, out int correctIndex)
        {
            List<string> answers = new List<string>(userQnA.IncorrectAnswers);
            answers.Add(userQnA.CorrectAnswer);

            // Create a Random instance to shuffle the answer choices.
            Random ran = new Random();

            // Shuffle the answer choices.
            answers = answers.OrderBy(_ => ran.Next()).ToList();

            // Find the index of the correct answer in the shuffled list.
            correctIndex = answers.IndexOf(userQnA.CorrectAnswer);

            return answers;
        }

    }
}
