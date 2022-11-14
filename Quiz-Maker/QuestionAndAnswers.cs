using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    public class QuestionAndAnswers

    {
        private readonly string _correctAnswer;

        public QuestionAndAnswers(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = new List<string>();
        }
        public string Question { get; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; }

    }

    /*public string falseAnswerOne { get; set; }          //TODO: this could maybe perhaps possilby be a list of string
    public string falseAnswerTwo { get; set; }        //TODO: this could maybe perhaps possilby be a list of string
    public string falseAnswerThree { get; set; }               //TODO: this could maybe perhaps possilby be a list of string
    public string correctAnswer { get; set; }*/


    //private int correctAnswerIndex; //TODO: this could maybe perhaps possilby be a list of string



}


