using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(',').Select(long.Parse).ToList();
            var lake = new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
