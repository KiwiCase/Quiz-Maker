﻿namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            Question question = new Question();
            question.userQuestion = "";
            question.answerOne = "";
            question.answerTwo = "";
            question.answerThree = "";
            question.correctAnswer = "";

            for (int i = 0; i < answer; i++)
            {
                List<string> QuestionAndAnswers = new List<string>();
                string userQuestion = UserInterface.AskQuestion();
                QuestionAndAnswers.Add(userQuestion);

                string correctAnswer = UserInterface.AskCorrectAnswer();
                QuestionAndAnswers.Add(correctAnswer);

                string answerOne = UserInterface.AskFirstFalseAnswer();
                QuestionAndAnswers.Add(answerOne);

                string answerTwo = UserInterface.AskSecondFalseAnswer();
                QuestionAndAnswers.Add(answerTwo);

                string answerThree = UserInterface.AskThirdFalseAnswer();
                QuestionAndAnswers.Add(answerThree);

            }

        }
    }
}