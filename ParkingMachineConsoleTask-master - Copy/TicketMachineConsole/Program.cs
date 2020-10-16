using System;

namespace ParkingMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ParkingMachine machine = new ParkingMachine(10);

            // Act
            machine.InsertMoney(10);
            machine.BuyTicket();
            machine.InsertMoney(40);
            machine.BuyTicket();

            Console.Write("hej");

        }
    }
}
