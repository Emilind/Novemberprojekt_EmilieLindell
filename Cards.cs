using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt_Emilie_Lindell
{
    public enum kortTyp // Jag använder mig av en enumeration för att kunna namnge dessa bestämda konstanter i då en enumeration list. Detta för att även kunna använda det inom denna klass där jag kommer anänvda det.
    {
        Hjärter, Klöver, Spader, Ruter
    }
    class Cards
    {
        public string visaKort { get; set; }

    }
}
