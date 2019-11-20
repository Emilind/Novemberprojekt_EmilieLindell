using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt_Emilie_Lindell
{
    class Kortlek : Kort
    {
        const int antalKort = 52; // Jag använder en "const" för att den är konstant och går inte att modify.
        private Kort[] leken; // detta är då en array som alla kort kommer ligga i

        public Kortlek()
        {
            leken = new Kort[antalKort]; // för att registera korten och antelet som en lek.

        }

        public Kort[] getleken {get { return leken; } }// denna metod använder jag för att hämta min kortlek

        public void funkandeKortlek()
        {
            int i = 0;
            foreach(kortTyp)
        }
    }
}
