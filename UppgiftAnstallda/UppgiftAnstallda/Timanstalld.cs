using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UppgiftAnstallda
{
    class Timanstalld : Anstalld
    {
        private double timlon;
        private double arbetadeTimmar;

        public Timanstalld(String fNamn, String eNamn, String pNum, double tLon, double arbTim)
        {
            fornamn = fNamn;
            efternamn = eNamn;
            personnummer = pNum;
            timlon = tLon;
            arbetadeTimmar = arbTim;
        }

        public override double BeraknaLon()
        {
            return timlon * arbetadeTimmar;
        }

        public override string ToString()
        {
            return base.ToString() + ", Timlön: " + timlon + ", Arbetade timmar: " + arbetadeTimmar + "Uträknad Lön: " + BeraknaLon();
        }
    }
}
