using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Fragesport_File
{
    public abstract class QuestionCard
    {
        protected String question;
        protected String answer;

        abstract public void PrintQuestion();
        abstract public String GetQuestion();
        abstract public List<String> GetChoice();
        abstract public String GetAnswer();

        public void GetInput(Score s)
        {
            string A = Console.ReadLine();
            Console.Clear();
            if (A.ToLower() == answer.ToLower())
            {
                Console.WriteLine("You Guessed correctly!!");
                s.AddScore();
            }
            else
            {
                Console.WriteLine("You Guessed incorrectly!!");
                s.AddMaxScore();
            }
            Console.WriteLine("Press ENTER to continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Console.Clear();
        }

        public String GetQuestionText() 
        {
            return question;
        }
    }
}