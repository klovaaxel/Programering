using System;
using System.Collections.Generic;

namespace Banking
{
    public class BankAccount
    {
        private string pin;
        private string accountNumber;
        private int balance;
        private List<Transfer> successfullTransfers;

        public BankAccount(string accountNumber, string pin)
        {
            
        }
        public BankAccount(string accountNumber, string pin, int balance) : this(accountNumber, pin)
        {
            
        }
        public String AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Transfer(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public bool ValidatePin(string pin)
        {
            throw new NotImplementedException();
        }

        public string GetAllTransfersAsString()
        {
            throw new NotImplementedException();
        }
        public List<Transfer> GetTransfers()
        {
            throw new NotImplementedException();
        }
    }
}
