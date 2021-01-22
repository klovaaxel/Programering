using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Fragesport_File
{
    public abstract class QuestionCard
    {
 
        protected String id;
        public string Id
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        protected String question;
        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }
        protected String answer;
        public string Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }

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