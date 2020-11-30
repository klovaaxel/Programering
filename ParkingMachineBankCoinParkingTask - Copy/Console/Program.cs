using System;
using System.Collections.Generic;
using System.Text;
using Banking;
using Parking;

namespace ConsoleApp
{
    class Program
    {
        static Bank bank = new Bank();
        static String accPin;
        static String accountNr;
        static String verAccPin;

        static void Main(string[] args)
        {
        int costPerHour = 30;
        String machinePin = "machine";
        String machineAccountNr = bank.AddAccount(machinePin);
        CoinParkingMachine coinParkingMachine = new CoinParkingMachine(costPerHour);
        CardParkingMachine cardParkingMachine = new CardParkingMachine(costPerHour, bank, machineAccountNr);

        PrintMainMenu();

        }
        static void PrintMainMenu()
        {
            Console.Clear();

            Console.WriteLine("press 1 to make new bank account");
            Console.WriteLine("press 2 to deposit money into existing account");
            Console.WriteLine("press 3 to buy ticket with bank");
            Console.WriteLine("press 4 to buy ticket with coins");

            string answer = Console.ReadLine();
            if (answer == "1")
            {
                PrintNewBankAccMenu();
            }
            else if (answer == "2")
            {
                PrintDepositMoneyMenu();
            }

        }

        static void PrintNewBankAccMenu()
        {
            Console.Clear();

            Console.WriteLine("Make a new Bank account");

            Console.WriteLine("Enter the wanted pin for your bank account");
            accPin = Console.ReadLine();
            Console.WriteLine("Enter pin again to verify");
            verAccPin = Console.ReadLine();

            if (accPin != verAccPin)
            {
                Console.WriteLine("Enter pin again to verify");
                verAccPin = Console.ReadLine();
            }

            accountNr = bank.AddAccount(accPin);

            Console.WriteLine("Your account number is " + accountNr);

            NextMenu();
            PrintMainMenu();
        }

        static void PrintDepositMoneyMenu() 
        {
            Console.Clear();

            Console.WriteLine("Enter balance you want to insert to account");
            Transfer transfer = new Transfer("1001", accountNr, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter pin to verify");
            verAccPin = Console.ReadLine();

            while (accPin != verAccPin)
            {
                Console.WriteLine("Pin does not match, try again");
                verAccPin = Console.ReadLine();
            }
            Console.WriteLine("Pin verified");

            bank.Transfer(transfer, verAccPin);

            Console.WriteLine("Added balance to account : " + accountNr);

            NextMenu();
            PrintMainMenu();
            
        }

        static void NextMenu() 
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
