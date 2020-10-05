using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftAnstallda
{
    class BasOchProvisionsanstalld : Provisionsanstalld
    {
        private double fastLon;

        public BasOchProvisionsanstalld(String fNamn, String eNamn, String pNum, double fLon, double provi, double forsalj)
        {
            fornamn = fNamn;
            efternamn = eNamn;
            personnummer = pNum;
            fastLon = fLon;
            provision = provi;
            forsaljning = forsalj;
        }

        public override double BeraknaLon()
        {
            return (provision / 100) * forsaljning;
        }
        public override string ToString()
        {
            return fornamn + efternamn + ", " + personnummer + ", Provision: " + provision + "försäljning (SEK): " + forsaljning;
        }
    }
    


}
