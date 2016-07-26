using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            var ivo = new Player(firstPlayer);
            var gosho = new Player(secondPlayer);
          
            var firstsuit =Enum.GetValues(typeof(Suits));
            var ivoList = new List<Card>();
            var goshoList = new List<Card>();
            string input = Console.ReadLine();
            while (ivoList.Count!=5)
            {
                string[] card = input.Split(' ');
                var rank = card[0];
                    var firstrank = Enum.Parse(typeof(Rank),rank);
              
                
            }
        }
    }
}
