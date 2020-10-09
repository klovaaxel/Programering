using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Fragesport
{
    class Program
    {
        static void Main(string[] args)
        {
            Score myScore = new Score();
            List<QuestionCard> questions = new List<QuestionCard>();

            questions.Add(new QuestionChoice("What animal causes the most power outages in the U.S.?", new List<string>(new string[] { "Squirrels", "Turtles", "Bears", "Snakes" }), "1"));
            questions.Add(new QuestionChoice("What is the inventor of the pringels can burried in?", new List<string>(new string[] {"Casket", "Pringels Can", "A big box", "His house"}), "2"));
            questions.Add(new QuestionChoice("What was spider webs used as in ancient times?", new List<string>(new string[] { "Clothes","Cutlary","Bandages","Food" }), "3"));
            questions.Add(new QuestionText("What is my name", "Axel"));

            foreach (var question in questions)
            {
                AskQuestion(question, myScore);
            }

            Console.WriteLine("your score is " + myScore.GetScore() + " / " + myScore.GetMaxScore());
        }
        static void AskQuestion(QuestionCard Q, Score s)
        {
            Q.PrintQuestion();
            Q.GetInput(s);
        }
    }
}