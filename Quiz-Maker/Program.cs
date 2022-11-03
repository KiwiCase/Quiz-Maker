﻿using System.Security.Cryptography.X509Certificates;

namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            if (answer > 0)
            {
                QuestionAndAnswers QnAOne = UserInterface.GetQuestionAndAnswers();
                Console.WriteLine($"Your first Question and Answers are as follows:\n\nFirst Question - {QnAOne.userQuestion}\n"
            }

        }
    }
}

