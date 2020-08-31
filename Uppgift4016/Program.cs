using System;

namespace Uppgift4016
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift_1();
            Console.WriteLine("");
            Uppgift_2();
            Console.WriteLine("");
            Uppgift_3A();
            Console.WriteLine("");
            Uppgift_3B();
            Console.WriteLine("");
            Uppgift_3C();
            Console.WriteLine("");
            Uppgift_3D();
            Console.WriteLine("");
            Uppgift_3E();
            Console.WriteLine("");
            Uppgift_3F();
            Console.WriteLine("");
            Uppgift_4();
            Console.WriteLine("");
            Uppgift_5ABC();
            Console.WriteLine("");
            Uppgift_6AB();
            Console.WriteLine("");
            Uppgift_7A();
            Console.WriteLine("");
            Uppgift_7B();
            Console.WriteLine("");
            Uppgift_7C();
            Console.WriteLine("");
            Uppgift_7D();
            Console.WriteLine("");
            Uppgift_7E();
            
        }

        static void Uppgift_1(){
            double tal = 5.71;
            String namn = "Babbage";
        }

        static void Uppgift_2(){
            Console.WriteLine("skriv ett heltal");
            String text = Console.ReadLine();
            int tal = Convert.ToInt32(text);

            if (tal >= 0)
            {
                Console.WriteLine("Talet är possitivt");
            }
            else
            {
                Console.WriteLine("Talet är negativt");
            }

            if (tal % 2 == 0)
            {
                Console.WriteLine("Talet är jämnt");
            }
            else
            {
                Console.WriteLine("talet är udda");
            }
        }

        static void Uppgift_3A(){
            int tal = 3;
            while (tal < 10)
            {
                Console.Write(tal + ", ");
                tal++;
            }
        }

        static void Uppgift_3B(){
            for (int i = 3; i < 10; i++)
            {
                Console.Write(i + ", ");
            }
        }

        static void Uppgift_3C() {
            int tal = 4;
            while (tal < 14)
            {
                Console.Write(tal + ", ");
                tal += 3;
            }
        }

        static void Uppgift_3D(){
            for (int i = 4; i < 14; i += 3){
                Console.Write(i + ", ");
            }
        }

        static void Uppgift_3E(){
            int tal = 30;
            while (tal > 14)
            {
                Console.Write(tal + ", ");
                tal -= 5;
            } 
        }

        static void Uppgift_3F(){
            for (int i = 30; i > 14; i -= 5)
            {
                Console.Write(i + ", ");
            }
        }

        static void Uppgift_4(){
            int[] vektor1 = new int[4];
            vektor1[0] = 7;
            vektor1[1] = 11;
            vektor1[2] = 17;
            vektor1[3] = 29;

            for (int i = 0; i < vektor1.Length; i++)
            {
                Console.Write(vektor1[i] + ", ");
            }

        }

        static void Uppgift_5ABC(){

            static void printName(String name){
                Console.WriteLine(name);
            }
        
            static String readName(){
                Console.Write("what is your name: ");
                String name = Console.ReadLine();
                return name;
            }
        
            printName("Axel Karlsson");
            Console.WriteLine(readName());
        }

        static void Uppgift_6AB(){
            static double adding(double num1, double num2){
                return (num1 + num2);
            }
        

        
            Console.Write("Enter first number: ");
            String sNum3 = Console.ReadLine();
            double num3 = Convert.ToDouble(sNum3);
            Console.Write("Enter second number: ");
            String sNum4 = Console.ReadLine();
            double num4 = Convert.ToDouble(sNum4);


            Console.WriteLine(num3 + " + " + num4 + " = " + adding(num3, num4));

        }

        static void Uppgift_7A(){
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Uppgift_7B(){
            for (int lines = 4; lines > 0; lines--)
            {
                for (int dot = 0; dot < lines; dot++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");   
                
            }
        }

        static void Uppgift_7C(){
            for (int lines = 0; lines <= 4; lines++)
            {
                for (int dot = 0; dot < lines; dot++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");   
                
            }
        }

        static void Uppgift_7D(){
            for (int lines = 0; lines <= 4; lines++)
            {
                for (int dot = 0; dot < lines; dot++)
                {
                    if (lines == 1)
                    {
                        Console.Write("   ");
                    } 
                    else if (lines == 2 && dot == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (lines == 3 && dot == 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");

                }  
                Console.WriteLine("");   
 
            }
        }

        static void Uppgift_7E(){
            for (int lines = 4; lines > 0; lines--)
            {
                for (int dot = 0; dot < lines; dot++)
                {
                    
                    if (lines == 3 && dot == 0)
                    {
                        Console.Write(" ");
                    } 
                    else if (lines == 2 && dot == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (lines == 1 && dot == 0)
                    { 
                        Console.Write("   ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine("");   
                
            }
        }


    }
}

