using System;
using System.Collections.Generic;
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

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pin"></param>
        /// <returns>Returns the account number if successful, otherwise null.</returns>
        public string AddAccount(string pin)
        {
            throw new NotImplementedException();
        }
        public string AddAccount(string pin, int balance)
        {
            throw new NotImplementedException();
        }
        public int GetBalance(string accountNr, string pin)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Call to transfer will fail either pin is wrong or the amount is bigger than allowed.
        /// </summary>
        /// <param name="transfer"></param>
        /// <param name="pin"></param>
        /// <returns>True if successful.</returns>
        public bool Transfer(Transfer transfer, string pin)
        {
            throw new NotImplementedException();
        }

        public List<Transfer> GetTransfers(string accountNr, string pin)
        {
            throw new NotImplementedException();
        }

        
    }
}
