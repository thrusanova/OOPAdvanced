using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
   public class Repair:IRepair
    {
        private string partName;
        private int hoursWork;

        public Repair(string partName,int hoursWork)
        {
            this.PartName = partName;
            this.HoursWork = hoursWork;
        }
        public int HoursWork { get; private set; }
      
        public string PartName { get; private set; }
      
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Part Name: {this.PartName} Hours Worked: {this.HoursWork}");
            return sb.ToString();
        }
    }
}
