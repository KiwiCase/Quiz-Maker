﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public static class UserInterface
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Casey's Quintessential Quiz Maker");
        }

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

        public static QuestionAndAnswers GetQuestionAndAnswers()
        {
            Console.WriteLine("Please type your question: ");
            string userQuestion = Console.ReadLine();

            Console.WriteLine("Please type the correct answer: ");
            string correctAnswer = Console.ReadLine();

            Console.WriteLine("Please type your first false answer: ");
            string falseAnswerOne = Console.ReadLine();

            Console.WriteLine("Please type your second false answer: ");
            string falseAnswerTwo = Console.ReadLine();

            Console.WriteLine("Please type your third false answer: ");
            string falseAnswerThree = Console.ReadLine();

            QuestionAndAnswers userQnA = new QuestionAndAnswers(userQuestion, correctAnswer);
            userQnA.IncorrectAnswers.AddRange(new string[] { falseAnswerOne, falseAnswerTwo, falseAnswerThree });

            return userQnA;
        }




    }
}
