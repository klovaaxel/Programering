using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    class Ticket
    {
        private int costPerHour;
        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
        }

        public TimeSpan GetValidTimeSpan() 
        {
            int days = Convert.ToInt32((currentTotal / costPerHour) / 24);
            int hours = Convert.ToInt32((currentTotal / costPerHour) % 24);
            int minutes = Convert.ToInt32((currentTotal * 60 / costPerHour) % 60);
            return new TimeSpan(days: days, hours: hours, minutes: minutes, seconds: 0);
        }
        public DateTime GetValidTo() 
        {
            DateTime date = DateTime.Now;
            date = date.Add(GetValidTimeSpan());
            return date;
        }

        public String ToString() 
        { 
            
        }
    }
}
