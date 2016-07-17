using Militaty.Interfaces;
using System.Text;

namespace Militaty
{
    public class Spy : Soldier,ISpy
    {
        private int codeNumber;
        public Spy(string firstName, string lastName, string id,int codeNumber) : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");
            return sb.ToString();
        }
    }
}
