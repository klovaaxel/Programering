using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftAnstallda
{
    class Fastanstalld : Anstalld
    {
        private double manadslon;
        public Fastanstalld(String fNamn, String eNamn, String pNum, double mlon) 
        {
            fornamn = fNamn;
            efternamn = eNamn;
            personnummer = pNum;
            manadslon = mlon;

        }
        public override double BeraknaLon()
        {
            return manadslon;
        }
        public override string ToString()
        {
            return fornamn + efternamn + ", " + personnummer + ", Måndaslön: " + BeraknaLon(); 
        }
    }

}
