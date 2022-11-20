using System;
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

        public static QuestionAndAnswers UserQuestionsAndAnswers(int answer, QuestionAndAnswers userQnA)
        {
            for (int i = 0; i < answer; i++)
            {
                userQnA = UserInterface.GetQuestionAndAnswers();
            } return userQnA;
        }

        public static void ReadyToPlayQuiz()
        {
            Console.WriteLine("All set! Press Enter to start the Quiz!");
            Console.ReadKey();   
        }
        
        public static bool AskQuestion(QuestionAndAnswers userQnA)
        {
            string[] answers = userQnA.GetShuffledAnswers(out int correctIndex);

            Console.WriteLine($"Question: {userQnA.Question}");
            Console.WriteLine("Answers:");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {answers[i]}");
            }
            int userPick = 0;
            do
            {
                Console.WriteLine("Pick one answer:");
                string input = Console.ReadLine();
                int.TryParse(input, out userPick);
            } while (userPick <= 0);

            return userPick - 1 == correctIndex;
        }
    }
}
