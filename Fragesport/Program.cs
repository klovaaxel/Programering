using System;

namespace Fragesport
{
    class Program
    {

        static int score = 0;
        static String[] question1 = {"What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "a", "A" }; 
        static String[] question2 = {"What was spider webs used as in ancient times?", "Clothes", "Cutlary", "Bandages", "Food", "c", "C" }; 
        static String[] question3 = {"What is the inventor of the pringels can burried in?", "Casket", "Pringels Can", "A big box", "His house", "b", "B" }; 

        static String[][] questions = {question1, question2, question3};


        static void Main(string[] args)
        {
            foreach (var item in questions)
            {
                askQuestion(item);
            }
            

            Console.WriteLine("your score is " + score);



        }

        static void askQuestion(string[] Q){
            Console.WriteLine(Q[0]);

            Console.WriteLine("");

            Console.WriteLine ("A - " + Q[1] + "  B - " + Q[2]);
            Console.WriteLine ("C - " + Q[3] + "  D - " + Q[4]);

            Console.WriteLine("");
            Console.WriteLine("Type the corresponding to the answer and press the ENTER key");
            string A = Console.ReadLine();
            Console.Clear();
            
            if (A == Q[5] || A == Q[6])
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