using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Banking
{
    public class BankAccount
    {
        private string pin;
        private string accountNumber;
        private int balance;
        private List<Transfer> successfullTransfers = new List<Transfer>();

        public BankAccount(string accountNumber, string pin)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
        }
        public BankAccount(string accountNumber, string pin, int balance) : this(accountNumber, pin)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
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
            if (accountNumber == transfer.ToAccountNr)
            {
                balance += transfer.Amount;
                successfullTransfers.Add(transfer);
                return true;
            }
            else if (accountNumber == transfer.FromAccountNr)
            {
                if (balance >= transfer.Amount)
                {
                    balance -= transfer.Amount;
                    successfullTransfers.Add(transfer);
                    return true;
                }
                return false;
            }
            else 
            {
                return false;
            }
        }

        public bool ValidatePin(string pin)
        {
            if (pin == this.pin) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public List<Transfer> GetTransfers()
        {
            return successfullTransfers;
        }
    }
}
