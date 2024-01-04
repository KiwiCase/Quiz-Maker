using System;
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

        public static void AskQuestion(QuestionAndAnswers userQnA)
        {
            int correctIndex;
            List<string> shuffledAnswers = QuizLogic.ShuffleAnswers(userQnA, out correctIndex);
            bool isCorrect = false;

            while (!isCorrect)
            {
                UserInterface.DisplayQuestionAndAnswers(userQnA, shuffledAnswers);
                int userPick = UserInterface.ValidateUserInput(shuffledAnswers);
                isCorrect = QuizLogic.CheckAnswer(userPick, correctIndex);
            }
        }
    }
}
