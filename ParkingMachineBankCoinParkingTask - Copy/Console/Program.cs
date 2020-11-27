using System;
using System.Collections.Generic;
using System.Text;
using Banking;
using Parking;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            CoinParkingMachine coinParkingMachine = new CoinParkingMachine(30);
            CardParkingMachine cardParkingMachine = new CardParkingMachine(30, bank, );
            PrintMainMenu();

        }

        static void PrintMainMenu()
        {
            Console.WriteLine("press 1 to make new bank account");
            Console.WriteLine("press 2 to deposit money into existing account");
            Console.WriteLine("press 3 to buy ticket with bank");
            Console.WriteLine("press 4 to buy ticket with coins");

            string answer = Console.ReadLine();
            if (answer == "1") 
            {
                PrintMainMenu();
            } 
        }

        static void PrintBankMenu()
        {
            Console.WriteLine("");
        }
    }
}
