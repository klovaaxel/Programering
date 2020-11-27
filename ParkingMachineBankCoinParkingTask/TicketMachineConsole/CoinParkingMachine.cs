using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class CoinParkingMachine : ParkingMachine
    {
        private List<Coin> coins = new List<Coin>();
        public CoinParkingMachine(int costPerH) : base(costPerH)
        {
        }
        public void InsertCoin(Coin Coin) 
        {
            coins.Add(Coin);
            int CoinVal = (int)Coin;
            InsertMoney(CoinVal);
        }
        public override Ticket BuyTicket()
        {
            coins.Clear();
            return base.BuyTicket();
        }
        public List<Coin> Refund()
        {
            return coins;
        }
    }
}
