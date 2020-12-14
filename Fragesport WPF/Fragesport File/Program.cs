﻿using Fragesport_File;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Fragesport_File
{
    public class Program
    {
        public List<QuestionCard> questions = new List<QuestionCard>();
        public int nextQ = 0;

        public static void Main(string[] args)
        {
           /* Score myScore = new Score();
            

            foreach (var question in questions)
            {
                AskQuestion(question, myScore);
            }

            Console.WriteLine("your score is " + myScore.GetScore() + " / " + myScore.GetMaxScore());
            */
        }
        public void start() 
        {
            FileReader File = new FileReader();
            File.ReadFromFile(questions);
        }
        private void AskQuestion(QuestionCard Q, Score s)
        {
            Q.PrintQuestion();
            Q.GetInput(s);
        }

        public QuestionCard GetNextQuestion() 
        {
            if (questions.Count > nextQ) 
            {
                QuestionCard question = questions[nextQ];
                nextQ++;
                return question;
            }
            else
            {
                return null;
            }
        }
        public QuestionCard GetPrevQuestion()
        {
            if (nextQ > 0)
            {
                nextQ--;
                QuestionCard question = questions[nextQ];
                return question;
            }
            else
            {
                return null;
            }  
        }

        public bool CheckAnswer(String answer, QuestionCard question, Score score) 
        {
            if (answer.ToLower() == question.GetAnswer().ToLower())
            {
                //"You Guessed correctly!!"
                score.AddScore();
                return true;
            }
            else
            {
                //"You Guessed incorrectly!!"
                score.AddMaxScore();
                return false;
            }
        }
    }
}