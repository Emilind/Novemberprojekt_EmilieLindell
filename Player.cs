using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt_Emilie_Lindell
{
    class Player
    {
        public string namn { get; set; }
        public Queue<Kort> Deck { get; set; }// Jag använder denna metod för att förafram kortleken och inte genom en list, för att en queue så köas strings och inte lagras som det gör i listor.

        
    }
}
