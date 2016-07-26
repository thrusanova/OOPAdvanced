using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndAtributes
{
    public class Card
    {
        private object item;
        private object num;

       

        public Card(Suit suit, Rank rank)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

    
    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }
}
}