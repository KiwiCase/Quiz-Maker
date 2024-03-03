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
                bool isCorrect = false;
                while (!isCorrect) // Loop until the answer is correct
                {
                    var shuffledAnswers = QuizLogic.ShuffleAnswers(qna);
                    int userPick = UserInterface.AskAndValidateQuestion(qna, shuffledAnswers);
                    isCorrect = QuizLogic.CheckAnswer(shuffledAnswers, userPick, qna.CorrectAnswer);

                    // Provide feedback and allow for reattempt if incorrect
                    isCorrect = UserInterface.ProvideFeedback(isCorrect);
                }
            }
        }
    }
}
