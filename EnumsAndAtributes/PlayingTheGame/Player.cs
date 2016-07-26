using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingTheGame
{
    public class Player
    {
        private List<Card> cards;
        private string name;
        public Player(string name)
        {
            this.cards = new List<Card>();
            this.name = name;
        }
        public void addCard(Card card)
        {
            cards.Add(card);
        }
        public Card takeTheHighestCard(List<Card>cards)
        {
            this.cards.Sort();
            return this.cards[cards.Count-1];
        }
       
    }
}
