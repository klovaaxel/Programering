using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class AccountNrGenerator
    {
        int currentAccountNr = 1000;

        public AccountNrGenerator()
        {
        }
        public string GetUniqieAccountNr()
        {
            currentAccountNr++;
            return Convert.ToString(currentAccountNr);
        }
    }
}
