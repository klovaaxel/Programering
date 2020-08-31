using System;
using System.Threading;

namespace EgenUppgift
{
    class Program
    {

        static int playerOnePosY = 5;
        static int ballPosX = 5;
        static int ballPosY = 5;
        static int points = 0;
        static bool ballDir = true;

        static Random randomGenerator = new Random();
        static void Main(string[] args)
        {
           
            drawArena();
            drawPlayerOne(5);
            drawBall(ballPosX, ballPosY);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        movePlayerOneUp();
                        moveBall();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        movePlayerOneDown();
                        moveBall();
                    }
                }
                drawArena();
                drawPlayerOne(playerOnePosY);
                moveBall();
                Thread.Sleep (1000 - points * 200);

            }
            

        }

        static void PrintAtPosition(int x, int y, string symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void drawPlayerOne(int y)
        {
            Console.Clear();
            drawArena();
            PrintAtPosition(2, y, "|");
        }

        static void drawBall(int x, int y){
            PrintAtPosition(x, y, "*");
        }

        static void drawArena()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("|----------" + points + "----------|");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("|                     |");
            }
            MoveText();

        }
        
        static void MoveText()
        {
            PrintAtPosition(0, 10, "|---------------------|");
        }

        static void movePlayerOneDown(){
            if (playerOnePosY < 9){
                playerOnePosY++;
                drawPlayerOne(playerOnePosY);
            } 
        }
        static void movePlayerOneUp(){
            if (playerOnePosY > 1){
                playerOnePosY--;
                drawPlayerOne(playerOnePosY);
            }  
        }

        static void moveBall(){
            
            drawBall(ballPosX, ballPosY);
            if (ballPosX >= 21)
            {
                ballPosY += randomGenerator.Next(-1, 2);
                ballDir = true;
            }else if (ballPosX <= 3 && playerOnePosY == 5){
                points++;
                ballPosY += randomGenerator.Next(-1, 2);
                ballDir = false;
            }else if (ballPosX < 3 && playerOnePosY != 5){
                Console.Clear();
                PrintAtPosition(10, 5, "You Lost");
                PrintAtPosition(10, 6, "Score: " + points);


            }

            if (ballDir == true)
            {
                ballPosX--;
            }else{
                ballPosX++;
            }
            
        }
    }
}
