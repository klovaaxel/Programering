using Banking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parking;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTicketMachine
{
    [TestClass]
    public class CoinParkingMachineTest
    {
        [TestMethod]
        public void InsertMoney()
        {
            // Arrange
            int costPerHour = 30;
            CoinParkingMachine machine = new CoinParkingMachine(costPerHour);

            // Act
            List<Coin> coinss = new List<Coin>();
            machine.InsertCoin(Coin.Ten);

            machine.BuyTicket();

            machine.InsertCoin(Coin.One);
            coinss.Add(Coin.One);
            machine.InsertCoin(Coin.Two);
            coinss.Add(Coin.Two);
            machine.InsertCoin(Coin.Five);
            coinss.Add(Coin.Five);
            machine.InsertCoin(Coin.Ten);
            coinss.Add(Coin.Ten);
            machine.InsertCoin(Coin.Two);
            coinss.Add(Coin.Two);

            // Assert
            CollectionAssert.AreEqual(coinss, machine.Refund());
        }
        [TestMethod]
        public void InsertMoneyTwo()
        {
            // Arrange
            TimeSpan expectedParkingTime;
            expectedParkingTime = new TimeSpan(
                days: 0,
                hours: 0,
                minutes: 30,
                seconds: 0);

            int costPerHour = 30;
            CoinParkingMachine machine = new CoinParkingMachine(costPerHour);

            // Act
            List<Coin> coinss = new List<Coin>();
            machine.InsertCoin(Coin.Ten);
            machine.InsertCoin(Coin.Five);
            machine.InsertCoin(Coin.Five);
            machine.InsertCoin(Coin.Two);
            machine.InsertCoin(Coin.One);
            machine.InsertCoin(Coin.One); //20

            machine.BuyTicket();

            machine.InsertCoin(Coin.Five);
            machine.InsertCoin(Coin.Two);
            machine.InsertCoin(Coin.One);
            machine.InsertCoin(Coin.One);
            machine.InsertCoin(Coin.Two);
            machine.InsertCoin(Coin.Two);
            machine.InsertCoin(Coin.Two); //15

            machine.BuyTicket();

            // Assert
            Assert.AreEqual(35, machine.Total);
            Assert.AreEqual(expectedParkingTime, machine.GetParkingTimeSpan());

        }
    }
}

