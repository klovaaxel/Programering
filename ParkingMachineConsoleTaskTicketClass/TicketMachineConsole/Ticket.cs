using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    public class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        private int days;
        private int hours;
        private int minutes;

        /// <summary>
        /// A ticket. Cannot be changed once created.
        /// </summary>
        /// <param name="price">The amount of money payed for the ticket. A hole number.</param>
        /// <param name="costPerHour">The cost per hour to park. A hole number.</param>
        public Ticket(int price, int costPerHour)
        {
            days = ((price / costPerHour) / 24);
            hours = ((price / costPerHour) % 24);
            minutes = (((price * 60 / costPerHour)) % 60);
        }

        public override String ToString()
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes" + Environment.NewLine;
        }
        /// <summary>
        /// Property to read cost per hour.
        /// </summary>

        /// <summary>
        /// Property to read the amout payed for the ticket.
        /// </summary>


            /// <summary>
            /// Returns the amount of time the ticket is valid for. 
            /// </summary>
            /// <returns>TimeSpan object with days, hours and minutes. 
            /// The number of seconds is set to zero.</returns>

            /// <summary>
            /// Returns the date and time the ticket is valid to.
            /// </summary>
            /// <returns>A DateTime object for the validity date.</returns>


        }
}
