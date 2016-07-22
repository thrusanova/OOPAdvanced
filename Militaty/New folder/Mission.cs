using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Mission : IMission
    {
        public string state;
        public string codeName;
        public string CodeName { get; private set; }
        public Mission(string codeName,string state)
        {
            this.State = state;
            this.CodeName = codeName;
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value == "inProgress" || value == "finished")
                {
                    this.state = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public void CompleteMission(IMission mission)
        {
            mission.State = "finished";
        }
           public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Code Name: {this.CodeName} State: {this.State}");
            return sb.ToString();
        }
    }
}
