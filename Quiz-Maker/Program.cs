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
                int correctIndex;
                var shuffledAnswers = QuizLogic.ShuffleAnswers(qna, out correctIndex);
                int userPick = UserInterface.AskAndValidateQuestion(qna, shuffledAnswers);
                bool isCorrect = QuizLogic.CheckUserAnswer(qna, userPick, correctIndex);

                // Use UserInterface class to provide feedback to the user
                UserInterface.ProvideFeedback(isCorrect);
            }
        }
    }
}
