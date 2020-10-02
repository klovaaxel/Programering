using System;
using System.Collections.Generic;

namespace Fragesport
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {

            List<QuestionCard> questions = new List<QuestionCard>();

            questions.Add(new QuestionChoice("What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "a"));
            questions.Add(new QuestionChoice("What is the inventor of the pringels can burried in?","Casket","Pringels Can","A big box","His house", "b"));
            questions.Add(new QuestionChoice("What was spider webs used as in ancient times?","Clothes","Cutlary","Bandages","Food","c"));

            foreach (var item in questions)
            {
                AskQuestion(item);
            }

            Console.WriteLine("your score is " + score);
        }
        static void AskQuestion(QuestionCard Q)
        {
            Q.PrintQuestion();
            Q.GetInput();
        }
    }
}