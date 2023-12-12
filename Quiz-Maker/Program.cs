﻿using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    public class Program
    {
        // Entry point of the program.
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int numberOfQuestions = UserInterface.HowManyQuestions();
            List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);
            UserInterface.ReadyToPlayQuiz();
            foreach (var qna in Qnas)
            {
                AskQuestion(qna);
            }
        }

        /// <summary>
        /// Handles the process of asking a question, including shuffling answers and checking the user's input.
        /// </summary>
        /// <param name="userQnA">QuestionAndAnswers object containing the question and answers.</param>
        public static void AskQuestion(QuestionAndAnswers userQnA)
        {
            int correctIndex;
            List<string> shuffledAnswers = ShuffleAnswers(userQnA, out correctIndex);
            DisplayQuestionAndAnswers(userQnA, shuffledAnswers);
            int userPick = ValidateUserInput(shuffledAnswers);
            CheckAnswer(userPick, correctIndex, shuffledAnswers);
        }

        // Shuffles the answers and returns the shuffled list along with the index of the correct answer.
        private static List<string> ShuffleAnswers(QuestionAndAnswers userQnA, out int correctIndex)
        {
            List<string> answers = new List<string>(userQnA.IncorrectAnswers);
            answers.Add(userQnA.CorrectAnswer);
            Random ran = new Random();
            answers = answers.OrderBy(_ => ran.Next()).ToList();
            correctIndex = answers.IndexOf(userQnA.CorrectAnswer);
            return answers;
        }

        // Displays the question and the shuffled answer choices.
        private static void DisplayQuestionAndAnswers(QuestionAndAnswers userQnA, List<string> shuffledAnswers)
        {
            Console.WriteLine($"Question: {userQnA.Question}");
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shuffledAnswers[i]}");
            }
        }

        // Validates the user's input and ensures it's within the valid range.
        private static int ValidateUserInput(List<string> shuffledAnswers)
        {
            int userPick;
            while (true)
            {
                Console.WriteLine("Pick one answer:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out userPick) && userPick > 0 && userPick <= shuffledAnswers.Count)
                {
                    break;
                }
            }
            return userPick;
        }

        // Checks if the user's answer is correct and provides feedback.
        private static void CheckAnswer(int userPick, int correctIndex, List<string> shuffledAnswers)
        {
            if (userPick - 1 == correctIndex)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is: {shuffledAnswers[correctIndex]}");
            }
        }
    }
}
