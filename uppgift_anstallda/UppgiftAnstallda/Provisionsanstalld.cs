using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UppgiftAnstallda
{
    class Provisionsanstalld : Anstalld
    {
        protected double provision;
        protected double forsaljning;

        public Provisionsanstalld(String fNamn, String eNamn, String pNum, double provi, double forsalj)
        {
            fornamn = fNamn;
            efternamn = eNamn;
            personnummer = pNum;
            provision = provi;
            forsaljning = forsalj;
        }

        public override double BeraknaLon()
        {
            return (provision / 100) * forsaljning;
        }
        public override string ToString()
        {
            return base.ToString() + ", Provision: " + provision + ", försäljning (SEK): " + forsaljning;
        }
    }

   
}
