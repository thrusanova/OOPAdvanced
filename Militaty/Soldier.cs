using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Soldier :ISoldier
    {
        public Soldier(string firstName,string lastName,string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
           
        }
        public string FirstName { get; private set; }
      
        public string Id { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            return sb.ToString();

        }

    }
}
