using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Banking
{
    public class Bank
    {
        // all accounts in the bank <account number, bank account>
        private Dictionary<String, BankAccount> accounts;
        private AccountNrGenerator accountNrGenerator;
        private List<Transfer> failingTransfers;


        public Bank()
        {
            accounts = new Dictionary<String, BankAccount>();
            accountNrGenerator = new AccountNrGenerator();
            failingTransfers = new List<Transfer>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pin"></param>
        /// <returns>Returns the account number if successful, otherwise null.</returns>
        public string AddAccount(string pin)
        {
            if (pin == null || pin == "") 
            {
                return null;
            }
            else{
                string accountNr = accountNrGenerator.GetUniqieAccountNr();
                accounts.Add(accountNr, new BankAccount(accountNr, pin));
                return accountNr;
            }
        }
        public string AddAccount(string pin, int balance)
        {
            if (pin == null || pin == "")
            {
                return null;
            }
            else
            {
                if (balance < 0) 
                {
                    balance = 0;
                }
                string accountNr = accountNrGenerator.GetUniqieAccountNr();
                accounts.Add(accountNr, new BankAccount(accountNr, pin, balance));
                return accountNr;
            }
        }
        public int GetBalance(string accountNr, string pin)
        {
            try
            {
                if (accounts[accountNr].ValidatePin(pin))
                {
                    return accounts[accountNr].Balance;
                }
                else
                {
                    return 0;
                }
            }
            catch 
            {
                return 0;
            }

        }
        /// <summary>
        /// Call to transfer will fail either pin is wrong or the amount is bigger than allowed.
        /// </summary>
        /// <param name="transfer"></param>
        /// <param name="pin"></param>
        /// <returns>True if successful.</returns>
        public bool Transfer(Transfer transfer, string pin)
        {
            if (accounts[transfer.FromAccountNr].ValidatePin(pin)) 
            {
                accounts[transfer.FromAccountNr].Transfer(transfer);
                accounts[transfer.ToAccountNr].Transfer(transfer);
                return true;
            }
            return false;
        }

        public List<Transfer> GetTransfers(string accountNr, string pin)
        {
            try
            {
                if (accounts[accountNr].ValidatePin(pin))
                {
                    return accounts[accountNr].SuccessfullTransfers;
                }
            }
            catch
            {
                return null;
            }
            return null;
        }    
    }
}
