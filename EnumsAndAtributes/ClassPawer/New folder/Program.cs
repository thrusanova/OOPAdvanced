using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPawer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstrank = (Rank)Enum.Parse(typeof(Rank),Console.ReadLine());
            // var firstsuit =(Suits)Enum.Parse(typeof(Suits),Console.ReadLine());
            // var caerd = new Card(firstsuit, firstrank);
            // var secondrank = (Rank)Enum.Parse(typeof(Rank), Console.ReadLine());
            // var secondsuit = (Suits)Enum.Parse(typeof(Suits), Console.ReadLine());
            // var secondcaerd = new Card(secondsuit, secondrank);
            // Console.WriteLine(caerd);
            //  if (caerd.CompareTo(secondcaerd)>0)
            //   {
            //       Console.WriteLine(caerd);
            //     }
            //    else
            //    {
            //      Console.WriteLine(secondcaerd);
            //  }
            var input = Console.ReadLine();

            if (input=="Rank")
            {
                var attributes = typeof(Rank).GetCustomAttributes(false);
                foreach (TypeAttribute atr in attributes)
                {
                    Console.WriteLine(atr);
                }
            }
            else
            {
                var attributes = typeof(Suits).GetCustomAttributes(false);
                foreach (var atr in attributes)
                {
                    Console.WriteLine(atr);
                }

            }
        }
        
    }
}
