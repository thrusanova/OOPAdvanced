using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public class Pet : IBirthDay
    {
        private string name;
        public Pet(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public string addBirthDay(string birthday)
        {
            return birthday;
        }
    }
}
