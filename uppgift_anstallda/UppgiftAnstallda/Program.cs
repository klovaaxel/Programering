using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UppgiftAnstallda
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            test.Run(Anstallda);
        }
    }

    class Test 
    {
        List<Anstalld> Anstallda = new List<Anstalld>();

        public void Run(List<Anstalld> list) 
        {

            Anstallda.Add(new Timanstalld("Axel", "Karlsson", "011218-XXXX", 100, 444));

            foreach (var anstalld in list)
            {
                Console.WriteLine(anstalld.ToString());
            }
        }
        
    }


   
}

