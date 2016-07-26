using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPawer
{
   public class TypeAttribute: Attribute
    {

        public string Type { get; set; }

        public string Category { get;set; }

        public string Description { get;set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
