using System;
using System.Collections.Generic;
using System.Text;
using Banking;

namespace Parking
{
    public class CardParkingMachine : ParkingMachine
    {
        private Bank bank;
        private String accountNr;
        private String customerAccountNr;
        private String customerPin;

        public CardParkingMachine(int costPerHour, Bank bank, String accountNr) : base(costPerHour)
        {
            this.bank = bank;
            this.accountNr = accountNr;
        }
        public void SetAccountNrAndPin(String accountNr, String pin)
        {
            customerAccountNr = accountNr;
            customerPin = pin;
        }
        public bool IsSetAccountNrAndPin()
        {
            if (accountNr == null || customerPin == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public new Ticket BuyTicket()
        {
            try
            {
                if (bank.Accounts[customerAccountNr].ValidatePin(customerPin))
                {
                    customerAccountNr = null;
                    customerPin = null;
                    return new Ticket(CurrentTotal, CostPerHour);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }                                                  

    }
}
