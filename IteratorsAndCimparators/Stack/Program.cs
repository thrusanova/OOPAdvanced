using Iteratorsl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var stack = new MyStack<int>();
            while (line!="END")
            {
                if (line.StartsWith("Push"))
                {
                    var input = line.Substring(4).Split(',').Select(int.Parse).ToList();
                    stack.Push(input);
                }
                else
                {
                    stack.Pop();
                }
                line = Console.ReadLine();
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
