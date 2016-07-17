
using System;

namespace Interfaces
{
    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        public Citizen(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public Citizen(string name, int age, string id, string birthdate) : this(name, age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }
       
        public string Id { get; private set; }
       
        public string Name { get; private set; }
        
    }
}
