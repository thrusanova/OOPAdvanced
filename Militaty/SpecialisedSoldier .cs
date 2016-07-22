using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
  public  class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
       
        public SpecialisedSoldier(string firstName, string lastName, string id, double salary,string corps) : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            set 
            {
                if ( value== "Airforces" || value == "Marines")
                {
                    this.corps = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

        }
        public override string ToString()
       
        {
            return base.ToString() + string.Format("Corps: {0}\n", this.corps);
            
        }
    }
}
