using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftAnstallda
{
    abstract class Anstalld
    {
        protected string fornamn;
        protected string efternamn;
        protected string personnummer;
        abstract public double BeraknaLon();
        abstract public String ToString();

    }
}
