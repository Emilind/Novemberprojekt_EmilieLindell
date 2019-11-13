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
        public Queue<Cards> Deck { get; set; }// Jag använder denna metod för att förafram kortleken och inte en list, för att en queue så köas strings
    }
}
