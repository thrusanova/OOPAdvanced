using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            var ivo = new Player(firstPlayer);
            var gosho = new Player(secondPlayer);

            var ivoList = new List<Card>();
            var goshoList = new List<Card>();
            string input = Console.ReadLine();
            Suits cardSuit;
            Rank cardRank;
           // var deck = new DeckOfCard();
            while (ivoList.Count != 5)
            {

                string[] card = input.Split(' ');
                var rank = card[0];
                var suit = card[2];
                var canParseSuit = Enum.TryParse(suit, out cardSuit);
                var canParseRank = Enum.TryParse(rank, out cardRank);
               // var firstrank = Enum.Parse(typeof(Rank), rank);
                if (!canParseSuit && !canParseRank)
                {
                    Console.WriteLine("No such card exists.");
                }
                else
                {
                    var firstrank = Enum.Parse(typeof(Rank), rank);
                    var firstsuit = (Rank)Enum.Parse(typeof(Suits), suit);
                    var cardd = new Card((Suits)firstsuit, (Rank)firstrank);
                    if (ivoList.Any(c => c.Suit == cardd.Suit && c.Rank == cardd.Rank)
                        || (goshoList.Any(c => c.Suit == cardd.Suit && c.Rank == cardd.Rank)))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        ivoList.Add(cardd);
                    }

                }
                input = Console.ReadLine();
            }
            while (goshoList.Count != 5)
            {

                string[] card = input.Split(' ');
                var rank = card[0];
                var suit = card[2];
                var canParseSuit = Enum.TryParse(suit, out cardSuit);
                var canParseRank = Enum.TryParse(rank, out cardRank);
               
                if (!canParseSuit && !canParseRank)
                {
                    Console.WriteLine("No such card exists.");
                }
                else
                {
                    var firstrank = (Rank)Enum.Parse(typeof(Rank), rank);
                    var firstsuit = (Rank)Enum.Parse(typeof(Suits), suit);
                    var cardd = new Card((Suits)firstsuit, (Rank)firstrank);
                    if (ivoList.Any(c => c.Suit == cardd.Suit && c.Rank == cardd.Rank)
                        || (goshoList.Any(c => c.Suit == cardd.Suit && c.Rank == cardd.Rank)))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        goshoList.Add(cardd);
                    }
                    if (goshoList.Count==5)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            var biggestIvoCard = ivoList.OrderByDescending(x => x.Power()).First();
            var biggestGoshoCard = goshoList.OrderByDescending(x => x.Power()).First();
            if (biggestIvoCard.Power()>biggestGoshoCard.Power())
            {
                Console.WriteLine($"{firstPlayer} wins with {biggestIvoCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer} wins with {biggestGoshoCard}.");
            }

        }
    }
}
