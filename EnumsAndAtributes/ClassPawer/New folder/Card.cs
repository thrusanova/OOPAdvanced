using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPawer
{
   public class Card:IComparable<Card>
    {
        public Card(Suits suit,Rank rank)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public Rank Rank { get; private set; }
        public Suits Suit { get; private set; }

        public int CompareTo(Card other)
        {
            return this.Power().CompareTo(other.Power());
        }

        public int Power()
        {
            return (int)this.Rank + (int)this.Suit;
        }
        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power()}";
        }
    }
}
