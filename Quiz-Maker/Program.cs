﻿namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            Question firstQuestion = new Question();
            firstQuestion.UserQuestion = "";
            firstQuestion.AnswerOne = "";
            firstQuestion.AnswerTwo = "";
            firstQuestion.AnswerThree = "";
            firstQuestion.AnswerFour = "";
            firstQuestion.CorrectAnswer = "";

            if (answer == 1)
            {
                UserInterface.AskQuestion();
                UserInterface.AskCorrectAnswer();
            }

        }
    }
}