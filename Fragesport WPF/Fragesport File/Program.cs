using Fragesport_File;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Data.SqlClient;

namespace Fragesport_File
{
    public class Program
    {
        public List<QuestionCard> questions = new List<QuestionCard>();
        public int nextQ = 0;

        public static void Main(string[] args)
        {
            /*Score myScore = new Score();


             foreach (var question in questions)
             {
                 AskQuestion(question, myScore);
             }

             Console.WriteLine("your score is " + myScore.GetScore() + " / " + myScore.GetMaxScore());
             */

            Console.WriteLine("Getting Connection ...");

            var datasource = @"DESKTOP-PC\SQLEXPRESS";//your server
            var database = "Students"; //your database name
            var username = "sa"; //username of server to connect
            var password = "password"; //password

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
        public void start() 
        {
            FileReader File = new FileReader();
            File.ReadFromFile(questions);
        }
        public void insertDB(List<QuestionCard> questions) 
        { 
            
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