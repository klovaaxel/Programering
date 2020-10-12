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

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
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

        public string BuyTicket() 
        {
            currentTotal += total;
            int tCurrentTotal = currentTotal;
            currentTotal = 0;
            return "Parking ticket valid for:" + Environment.NewLine +
                ((tCurrentTotal / costPerHour) / 24) + " days" + Environment.NewLine +
                ((tCurrentTotal / costPerHour) % 24) + " hours" + Environment.NewLine +
                ((tCurrentTotal *60 / costPerHour)) % 60 + " minutes";

        }
    }
}
