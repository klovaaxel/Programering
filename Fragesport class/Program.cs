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

            questions.Add(new QuestionCard("What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "a"));
            questions.Add(new QuestionCard("What is the inventor of the pringels can burried in?","Casket","Pringels Can","A big box","His house", "b"));
            questions.Add(new QuestionCard("What was spider webs used as in ancient times?","Clothes","Cutlary","Bandages","Food","c"));

            foreach (var item in questions)
            {
                AskQuestion(item);
            }

            Console.WriteLine("your score is " + score);
        }
        static void AskQuestion(QuestionCard Q)
        {
            Console.WriteLine(Q.Question);

            Console.WriteLine("");

            Console.WriteLine ("A - " + Q.a + "  B - " + Q.b);
            Console.WriteLine ("C - " + Q.c + "  D - " + Q.d);

            Console.WriteLine("");
            Console.WriteLine("Type the corresponding to the answer and press the ENTER key");
            string A = Console.ReadLine();
            Console.Clear();
            
            if (A.ToLower() == Q.answer)
            {
                Console.WriteLine("You Guessed correctly!!");
                score++;
            }else
            {
                Console.WriteLine("You Guessed incorrectly!!");
            }
            Console.WriteLine("Press ENTER to continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                
            }
            Console.Clear();
        }
    }
}