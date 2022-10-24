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

        public static void GetQuestionAndAnswers()
        {
            static string AskQuestion()                                                       
            {                                                                                        
                Console.WriteLine("Please type your question: ");                                   
                string UserQuestion = Console.ReadLine();                                           
                return UserQuestion;                                                          
            }

            static string AskCorrectAnswer()                                                  
            {                                                                                      
                Console.WriteLine("Please type the correct answer: ");                               
                string CorrectAnswer = Console.ReadLine();                                           
                return CorrectAnswer;                                                               
            }

            static string AskFirstFalseAnswer()                                              
            {                                                                                       
                Console.WriteLine("Please type your first false answer: ");                          
                string AnswerOne = Console.ReadLine();                                              
                return AnswerOne;                                                                   
            }

            static string AskSecondFalseAnswer()
            {
                Console.WriteLine("Please type your second false answer: ");
                string AnswerTwo = Console.ReadLine();
                return AnswerTwo;

            }

            static string AskThirdFalseAnswer()
            {
                Console.WriteLine("Please type your third false answer: ");
                string AnswerThree = Console.ReadLine();
                return AnswerThree;
            }

        }
                                                                                                                                                                             


    }
}
