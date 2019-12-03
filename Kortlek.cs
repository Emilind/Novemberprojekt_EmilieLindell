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

        public Kort[] hämtaLeken {get { return leken; } }// denna metod använder jag för att hämta min kortlek

        public void funkandeKortlek()
        {
            int i = 0;
            foreach(kortTyp k in Enum.GetValues(typeof(kortTyp)))
            {
                foreach(värde v in Enum.GetValues(typeof(värde)))
                {
                    leken[i] = new Kort { tecken = k, kortVärde = v };
                    i++;
                }
            }
            blandning();
        }
        
        public void blandning()//Jag anävnder mig av en void för att skapa metoden som "blandar" korten, så att jag sedan kan ropa på den i min loop. 
        {
            Random gen = new Random();
            Kort temp;

            for (int antalBlandningar = 0; antalBlandningar < 10; antalBlandningar++)//denna kod visar på att den kommer blanda korten 10 gånger
            {
                for (int i = 0; i < antalKort; i++)//detta är för att då går den igenom de 52 korten som leken består av och då ess till kung. jag "omvandlar" typ det då för att få fram korten.
                {
                    int korti = gen.Next(13);
                    temp = leken[i];
                    leken[i] = leken[korti];
                    leken[korti] = temp;
                    
                }
            }
        }
       
    }
}
