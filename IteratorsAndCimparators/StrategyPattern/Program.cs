using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var ageSet = new SortedSet<Person>(new CompareName());
            var nameSet = new SortedSet<Person>(new CompareAge());
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                ageSet.Add(person);
                nameSet.Add(person);
            }
         
            foreach (var person in ageSet)
            {
                Console.WriteLine(person);
            }
            foreach (var person in nameSet)
            {
                Console.WriteLine(person);
            }
        }
    }
}
