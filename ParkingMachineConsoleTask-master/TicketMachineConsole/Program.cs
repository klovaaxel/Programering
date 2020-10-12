using System;

namespace TicketMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parking ticket valid for:" + Environment.NewLine +
                ((1025 / 20) / 24) + " days" + Environment.NewLine +
                ((1025 / 20) % 24) + " hours" + Environment.NewLine +
                ((1025 / 20) % 24 % 1 * 60d) + " minutes");
        }
    }
}
