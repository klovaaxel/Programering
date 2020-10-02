using System;
using System.Security.Cryptography.X509Certificates;

namespace Fragesport
{
    abstract class QuestionCard
    {
        protected String question;
        protected String answer;

        abstract public void PrintQuestion();

        public void GetInput() 
        {
            string A = Console.ReadLine();
            Console.Clear();
            if (A.ToLower() == answer)
            {
                Console.WriteLine("You Guessed correctly!!");
                //score++;
            }
            else
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