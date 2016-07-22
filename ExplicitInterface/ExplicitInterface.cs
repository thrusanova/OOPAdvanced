using ExplicitInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ExplicitInterface

{
    public class Citizen : IResident, IPerson

    {
        public Citizen(string name,string country,int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        public int Age { get; private set; }
      
        public string Country { get; private set; }

        public string Name { get; private set; }

        string IResident.GetName()
        {
           return $"Mr/Ms/Mrs "+this.Name;
          //  Console.WriteLine(this.Name);
        }
        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
