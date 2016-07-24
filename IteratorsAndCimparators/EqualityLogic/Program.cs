using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var ageSet = new SortedSet<Person>();
            var nameSet = new HashSet<Person>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                ageSet.Add(person);
                nameSet.Add(person);
            }
            Console.WriteLine(ageSet.Count);
            Console.WriteLine(nameSet.Count);

        }
    }
}
