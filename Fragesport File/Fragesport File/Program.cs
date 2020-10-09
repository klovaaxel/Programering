using Fragesport_File;
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
            FileReader File = new FileReader();

            File.ReadFromFile(questions);

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