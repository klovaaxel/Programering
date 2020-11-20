using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class CoinParkingMachine : ParkingMachine
    {
        private List<Coin> coins = new List<Coin>();
        public CoinParkingMachine(int costPerH) 
        {
            costPerHour = costPerH;
        }
        public enum Coin : int
        {
            One = 1,
            Two = 2,
            Five = 5,
            Ten = 10
        }

        public void InsertCoin(Coin Coin) 
        {
            coins.Add(Coin);
            int CoinVal = (int)Coin;
            InsertMoney(CoinVal);
        } 

        public List<Coin> Refund()
        {
            return coins;
        }
    }
}
