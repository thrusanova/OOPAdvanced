using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borderControl
{
    public class Citizen:IBirthDay,IBuyer
    {
        private string name;

        private int age;

        private string id;

        public Citizen(string name,int age,string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public int Food { get; private set; }

        public string addBirthDay(string birthday)
        {
            return birthday;
        }

        public int buyFood()
        {
          return  this.Food += 10;
        }
    }
}
