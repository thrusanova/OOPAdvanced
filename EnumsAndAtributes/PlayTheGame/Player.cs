using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTheGame
{
    public class Player
    {
        private List<Card> cards;
        private string Name;
        public Player(string name)
        {
            this.cards = new List<Card>();
        }
        // public Player(List<Card>cards)
        //  {
        //  }

        //public List<Card> Cards { get; private set; }
    }
}