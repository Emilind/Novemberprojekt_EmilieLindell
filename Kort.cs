using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Novemberprojekt_Emilie_Lindell
{
    public enum kortTyp // Jag använder mig av en enumeration för att kunna namnge dessa bestämda konstanter i då en enumeration list. Detta för att även kunna använda det inom denna klass där jag kommer anänvda det.
    {
        Hearts, Clubs, Spades, Diamonds
    }
    public enum värde
    {
        TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN,
        JACK, QUEEN, KING
           

    }
    class Kort
    {
        public string visaKort { get; set; }//Jag använder det för att kunna på ett kortfattat sätt skriva den typen av egenskap
        public värde kortVärde { get; set; } // För att sedan kunna visa vilket värde kortet har
        public kortTyp tecken { get; set; } // För att sedan kunna visa vilket tecken kortet har

       

}    
         
    }

