using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Private : ISoldier,IPrivate
    {

        public Private(string firstName, string lastName, string id, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Salary = salary;
        }
        public string FirstName { get; private set; }

        public string Id { get; private set; }

        public string LastName { get; private set; }

        public double Salary { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            return sb.ToString();

        }

    }
}

