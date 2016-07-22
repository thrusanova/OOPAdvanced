using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
  public class MilitaryUnit
    {
        private List<IPrivate> allPrivates;

        public MilitaryUnit()
        {
            this.allPrivates = new List<IPrivate>();
        }

        public void addPrivate(IPrivate privateSoldier)
        {
            this.allPrivates.Add(privateSoldier);
        }
        public List<IPrivate> getAllPrivates()
        {
            return this.allPrivates;
        }
    }
}
