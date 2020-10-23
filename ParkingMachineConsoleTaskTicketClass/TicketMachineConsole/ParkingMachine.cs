using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;
        public int Total
        {
            get
            {
                return Total;
            }
        }

        // Total for the current customer.
        private int currentTotal;
        public int CurrentTotal 
        {
            get
            {
                return currentTotal;
            }
        }

        // Cost to park.
        private int costPerHour;
        public int CostPerHour
        {
            get
            {
                return CostPerHour;
            }
        }

        public ParkingMachine(int costPerH)
        {
            total = 0;
            currentTotal = 0;
            costPerHour = costPerH;
        }
        public void InsertMoney(int money) 
        {
            if (money > 0)
            {
                currentTotal += money;
            }
        }

        public int Cancel() 
        {
            int tCurrentTotal = currentTotal;
            currentTotal = 0;
            return tCurrentTotal;
        }

        public Ticket BuyTicket() 
        {
            total += currentTotal;
            Console.WriteLine(total);
            int tCurrentTotal = currentTotal;
            currentTotal = 0;
            return new Ticket(currentTotal, costPerHour);
        }

        public TimeSpan GetParkingTimeSpan() 
        {
            return new TimeSpan(days: ((currentTotal / costPerHour) / 24), 
                                hours: ((currentTotal / costPerHour) % 24), 
                                minutes: (((currentTotal * 60 / costPerHour)) % 60), 
                                seconds: 0);
        }
        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            date = date.Add(new TimeSpan(days: ((currentTotal / costPerHour) / 24), 
                                        hours: ((currentTotal / costPerHour) % 24), 
                                        minutes: (((currentTotal * 60 / costPerHour)) % 60), 
                                        seconds: 0));
           return date;
        }
    }
}
