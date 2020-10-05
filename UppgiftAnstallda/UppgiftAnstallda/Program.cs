using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UppgiftAnstallda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Anstalld> Anstallda = new List<Anstalld>();

            Anstallda.Add(new Timanstalld("Axel", "Karlsson", "011218-XXXX", 100, 444));

            foreach (var anstalld in Anstallda) 
            {
                Console.WriteLine(anstalld.ToString());
            }
        }
    }
}

