using System;

namespace Fragesport
{
    class Program
    {
        static Question myQuestion;
        static int score = 0;
        //static String[][] questions = {question1, question2, question3};
        static void Main(string[] args)
        {
            myQuestion = new Question("What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "a");
            var question10 = new Question("What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "a");
            

            Console.WriteLine("your score is " + score);



        }

        static void askQuestion(Question Q){
            Console.WriteLine(Q.question);

            Console.WriteLine("");

            Console.WriteLine ("A - " + Q.a + "  B - " + Q.b);
            Console.WriteLine ("C - " + Q.c + "  D - " + Q.d);

            Console.WriteLine("");
            Console.WriteLine("Type the corresponding to the answer and press the ENTER key");
            string A = Console.ReadLine();
            Console.Clear();
            
            if (A == Q.answer)
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
