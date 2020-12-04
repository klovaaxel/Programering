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

        static int costPerHour = 30;
        static String machinePin = "machine";
        static String machineAccountNr = bank.AddAccount(machinePin);

        static CoinParkingMachine coinMachine = new CoinParkingMachine(costPerHour);
        static CardParkingMachine cardMachine = new CardParkingMachine(costPerHour, bank, machineAccountNr);

        static void Main(string[] args)
        {
            PrintMainMenu();
        }
        static void PrintMainMenu()
        {
            string answer = "0";
            Console.Clear();

            Console.WriteLine("press 1 to make new bank account");
            Console.WriteLine("press 2 to check the balance of your account");
            Console.WriteLine("press 3 to buy ticket with bank account");
            Console.WriteLine("press 4 to buy ticket with coins");

            answer = Console.ReadLine();
            if (answer == "1")
            {
                PrintNewBankAccMenu();
            }
            else if (answer == "2")
            {
                PrintBalance();
            }
            else if (answer == "3")
            {
                PrintBuyTicket();
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

            confirmPin();

            Console.WriteLine("Enter starting balance");

            accountNr = bank.AddAccount(accPin, Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Your account number is " + accountNr);

            NextMenu();
            PrintMainMenu();
        }

        static void PrintBalance()
        {
            Console.Clear();

            Console.WriteLine("Enter pin for account " + accountNr + " to verify");
            verAccPin = Console.ReadLine();

            confirmPin();

            Console.WriteLine("Your Account :" + accountNr + " currently has a balance of " + bank.GetBalance(accountNr, accPin));

            NextMenu();
            PrintMainMenu();
        }

        static void PrintBuyTicket()
        {
            Console.WriteLine("insert PIN to confirm");
            cardMachine.SetAccountNrAndPin(accountNr, Console.ReadLine());

            Console.WriteLine("Enter the amount you want to insert, the price per hour is : " + costPerHour);
            cardMachine.InsertMoney(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("press Y to buy ticket or any other key to cancel");
            if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
            {
                Ticket myTicket = cardMachine.BuyTicket();
                Console.WriteLine(myTicket.ToString());
            }
            else 
            {
                cardMachine.Cancel();
            }

            Console.Clear();

            NextMenu();
            PrintMainMenu();
        }
        static void NextMenu()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        static void confirmPin() 
        {
            while (accPin != verAccPin)
            {
                Console.WriteLine("Pin does not match, try again");
                verAccPin = Console.ReadLine();
            }
            verAccPin = null;
        }
    }
}
