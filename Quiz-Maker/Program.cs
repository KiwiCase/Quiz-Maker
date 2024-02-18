using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.WelcomeMessage();
            int numberOfQuestions = UserInterface.HowManyQuestions();
            List<QuestionAndAnswers> Qnas = UserInterface.UserQuestionsAndAnswers(numberOfQuestions);
            UserInterface.ReadyToPlayQuiz();

            foreach (var qna in Qnas)
            {
                var shuffledAnswers = QuizLogic.ShuffleAnswers(qna);
                int userPick = UserInterface.AskAndValidateQuestion(qna, shuffledAnswers);
                bool isCorrect = QuizLogic.CheckAnswer(shuffledAnswers, userPick, qna.CorrectAnswer);

                UserInterface.ProvideFeedback(isCorrect);
            }
        }
    }
}
