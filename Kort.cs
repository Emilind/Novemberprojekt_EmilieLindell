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
    class Cards
    {
        public string visaKort { get; set; }//Jag använder det för att kunna på ett kortfattat sätt skriva den typen av egenskap
        public värde kortVärde { get; set; } // För att sedan kunna visa vilket värde kortet har
        public kortTyp tecken { get; set; } // För att sedan kunna visa vilket tecken kortet har

        public static class mellanting//Jag skapa denna metod för att kunna skapa det som kopplar själva korten och gör koden enklare
        {

            public static void Enqueue(this Queue<Cards> cards, Queue<Cards> newCards)//jag använde detta för att "enqueue" kan köa five strings i taget. Och jag tänkte implantera något sätt (vet inte än vad) så att det hela tiden sätts in nya kort i enqueue.
            {
                foreach (var card in newCards)// användningen av "var" är för att då behöver dem inte vara en explicit typ. "in" använder jag för att kunna passera denna parameter i detta fall igenom "var" utan att ändra värdet.
                {
                    cards.Enqueue(card);
                }
            }
        }


        public static class Kortdack // det är i denna metod som jag tänker börja göra själva korten och strukturera upp alla olika korttyper såsom ess, damer och kungar osv. Jag gör den static för att det ska funka samma över alla olika classes.
        {
            public static Queue<Cards> CreateCards()
            {
                Queue<Cards> cards = new Queue<Cards>();
                for (int i = 2; i <= 14; i++)
                {
                    foreach (kortTyp symbol in enum.getvärde(typeo(kortTyp)))
                     {}///???? funkar den? Ta reda på!!!!

                }
                
             }
    public int Count => Cards.Count; 
        }
         public void shuffle()
{
    var random = new Random();
    for (int i = 0; < cards.Count; i++; )
}    
         
    }
}
