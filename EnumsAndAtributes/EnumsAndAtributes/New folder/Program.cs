using System;

namespace EnumsAndAtributes
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Card Deck");
            var suits = Enum.GetValues(typeof(Suit));
            var rank = Enum.GetValues(typeof(Rank));
            
            foreach (var item in suits)
            {
                foreach (var num in rank)
                {
                    var card = new Card((Suit)item,(Rank)num);
                    Console.WriteLine(card);
                }
            }
        }
    }
}
