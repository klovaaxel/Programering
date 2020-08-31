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
        static void Main()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            playerOnePosY = 5;
            ballPosX = 5;
            ballPosY = 5;
            points = 0;
            ballDir = true;

            gameStart();

            drawArena();
            drawPlayerOne(5);
            drawBall(ballPosX, ballPosY);

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
                
                //Thread.Sleep((2 >> points) *1000);
                Thread.Sleep(100);

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
            PrintAtPosition(2, y, "▐");
        }

        static void drawBall(int x, int y){
            PrintAtPosition(x, y, "■");
        }

        static void drawArena()
        {
            Console.SetCursorPosition(0, 0);
            if (points < 10)
            {
                Console.WriteLine("┏Shitty Pong━━━━━ " + points + " ━━━┓");
            }else{
                Console.WriteLine("┏Shitty Pong━━━━━ " + points + " ━━┓");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("┃                      ┃");
            }
            MoveText();

        }
        
        static void MoveText()
        {
            PrintAtPosition(0, 10, "┗━━━━━━━━━━━━━━━━━━━━━━┛");
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
                if (ballPosY == 9){
                    ballPosY += randomGenerator.Next(-1, 1);
                }else if(ballPosY == 2){
                    ballPosY += randomGenerator.Next(0, 2);
                }else{
                    ballPosY += randomGenerator.Next(-1, 2);
                }
                ballDir = true;
            }else if (ballPosX <= 3 && playerOnePosY == ballPosY){
                points++;
                if (ballPosY == 9){
                    ballPosY += randomGenerator.Next(-1, 1);
                }else if(ballPosY == 2){
                    ballPosY += randomGenerator.Next(0, 2);
                }else{
                    ballPosY += randomGenerator.Next(-1, 2);
                }
                ballDir = false;
            }else if (ballPosX < 3 && playerOnePosY != ballPosY){
                endGame();
                
            }

            if (ballDir == true)
            {
                ballPosX--;
            }else{
                ballPosX++;
            }   
        }
        static void endGame(){
            Console.Clear();
            PrintAtPosition(10, 5, "You Lost");
            PrintAtPosition(10, 6, "Score: " + points);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press 'R' to restart.");
            while (Console.ReadKey().Key != ConsoleKey.R)
            {
                
            }
            Main();
        }

        static void gameStart(){
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("   _____ ");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("  |___ / ");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("    |_ \\ ");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("   ___) |");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("  |____/ ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("   ____  ");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("  |___ \\ ");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("    __) |");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("   / __/");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("  |_____|");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("   _ ");
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("  / |");
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("  | |");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("  | |");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("  |_|");
            Thread.Sleep(1000);


        }
    }
}



      