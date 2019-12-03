using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt_Emilie_Lindell
{
    class Utdelaren : Kortlek
    {
        private Kort[] dinHand;

        public Utdelaren()
        {
            dinHand = new Kort[4];
        }

        public void utdelning()
        {
            funkandeKortlek();
            handen();
        }
        public void handen()
        {
            for (int i = 0; i < 4; i++) ;
            dinHand[i] = hämtaLeken[i];
        }
    
     


  
    }
}
