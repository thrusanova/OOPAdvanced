using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Engineer : SpecialisedSoldier, IEngineer

    {
        private List<IRepair> repairs;
        public Engineer(string firstName, string lastName, string id, double salary,string crops) : base(firstName, lastName, id, salary,crops)
        {
            this.repairs = new List<IRepair>();
        }
        public void addRepair(string partName,int workHours)
        {
            IRepair repart = new Repair(partName, workHours);
            this.repairs.Add(repart);
        }
     
        public List<IRepair> getRepairs { get; private set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Repairs:");
            foreach (var pr in repairs)
            {
                sb.AppendFormat(pr.ToString());
            }
           return base.ToString() + sb.ToString();
        }
    }
}
    
