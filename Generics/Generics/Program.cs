using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var box = new List<string>();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();
                box.Add(input);
            }
            string line = Console.ReadLine();
            int count = returnCoun(box, line);
            // string[] line = Console.ReadLine().Split(' ');
            //   int firstInd = int.Parse(line[0]);
            //  int secondInd = int.Parse(line[1]);
            // var temp = box[firstInd];
            //  box[firstInd] = box[secondInd];
            //  box[secondInd] = temp;
            //  Console.WriteLine(box);
            Console.WriteLine(count);
        }

        public static int returnCoun<T>(List<T> list, T element) where T:IComparable
        {
            int count = 0;
            foreach (T item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
