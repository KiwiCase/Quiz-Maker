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

        public static string AskQuestion()                                                       //TODO: CONSOLIDATE
        {                                                                                        //TODO: CONSOLIDATE
            Console.WriteLine("Please type your question: ");                                    //TODO: CONSOLIDATE
            string UserQuestion = Console.ReadLine();                                            //TODO: CONSOLIDATE
            return UserQuestion;                                                                 //TODO: CONSOLIDATE
        }                                                                                        //TODO: CONSOLIDATE
                                                                                                 //TODO: CONSOLIDATE
        public static string AskCorrectAnswer()                                                  //TODO: CONSOLIDATE
        {                                                                                        //TODO: CONSOLIDATE
            Console.WriteLine("Please type the correct answer: ");                               //TODO: CONSOLIDATE
            string CorrectAnswer = Console.ReadLine();                                           //TODO: CONSOLIDATE
            return CorrectAnswer;                                                                //TODO: CONSOLIDATE
        }                                                                                        //TODO: CONSOLIDATE
                                                                                                 //TODO: CONSOLIDATE
        public static string AskFirstFalseAnswer()                                               //TODO: CONSOLIDATE
        {                                                                                        //TODO: CONSOLIDATE
            Console.WriteLine("Please type your first false answer: ");                          //TODO: CONSOLIDATE
            string AnswerOne = Console.ReadLine();                                               //TODO: CONSOLIDATE
            return AnswerOne;                                                                    //TODO: CONSOLIDATE
        }                                                                                        //TODO: CONSOLIDATE
                                                                                                 //TODO: CONSOLIDATE
        public static string AskSecondFalseAnswer()                                              //TODO: CONSOLIDATE
        {                                                                                        //TODO: CONSOLIDATE
            Console.WriteLine("Please type your second false answer: ");                         //TODO: CONSOLIDATE
            string AnswerTwo = Console.ReadLine();                                               //TODO: CONSOLIDATE
            return AnswerTwo;                                                                    //TODO: CONSOLIDATE
                                                                                                 //TODO: CONSOLIDATE
        }                                                                                        //TODO: CONSOLIDATE
                                                                                                 //TODO: CONSOLIDATE
        public static string AskThirdFalseAnswer()                                               //TODO: CONSOLIDATE
        {                                                                                        //TODO: CONSOLIDATE
            Console.WriteLine("Please type your third false answer: ");                          //TODO: CONSOLIDATE
            string AnswerThree = Console.ReadLine();                                             //TODO: CONSOLIDATE
            return AnswerThree;                                                                  //TODO: CONSOLIDATE
        }


    }
}
