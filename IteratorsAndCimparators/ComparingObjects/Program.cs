using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{

    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ');
            var people = new List<Person>();
            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];
                var person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine().Split(' ');
            }
            int count = int.Parse(Console.ReadLine());
            if (count>people.Count-1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                people[count].DuplicatePerson(people);
            }

        }
    }
}
