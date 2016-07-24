using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            int result = string.Compare(this.name, other.name, StringComparison.Ordinal);
            if (result == 0)
            {
                result = this.age.CompareTo(other.age);
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }
            if (this.CompareTo(item) == 0)
            {
                return true;
            }

            return false;
        }
        public override int GetHashCode()
        {
            int hash = this.age;
            hash = hash * 435 + this.name.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }

    }
    }
