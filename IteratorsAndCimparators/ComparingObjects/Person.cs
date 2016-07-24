using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name,int age,string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            if (this.name==other.name && this.age==other.age && this.town==other.town)
            {
                return 1;
            }           
                return 0;
        }
        public void DuplicatePerson(List<Person> people)
        {
            var newPerson = new Person(this.name, this.age, this.town);
            var count = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(newPerson)==1)
                {
                    count++;
                }
            }
            if (count==1)
            {
                Console.WriteLine("No matches");
            }
            Console.WriteLine($"{count} {people.Count-count} {people.Count}");
        }

        
    }
}
