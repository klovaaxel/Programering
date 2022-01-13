using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftAnstallda
{
    class BasOchProvisionsanstalld : Provisionsanstalld
    {
        private double fastLon;

        public BasOchProvisionsanstalld(String fNamn, String eNamn, String pNum, double fLon, double provi, double forsalj) : base(fNamn, eNamn, pNum, provi, forsalj)
        {
            fastLon = fLon;
        }

        public override double BeraknaLon()
        {
            return (provision / 100) * forsaljning;
        }
        public override string ToString()
        {
            return base.ToString() + personnummer + ", Provision: " + provision + ", försäljning (SEK): " + forsaljning;
        }
    }
    


}
