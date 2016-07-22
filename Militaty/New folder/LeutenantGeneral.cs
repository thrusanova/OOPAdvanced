using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class LeutenantGeneral :Private, ILeutenantGeneral,ISoldier
     {
        private List<IPrivate> privates;
        public LeutenantGeneral(string firstName, string lastName, string id, double salary) : base(firstName, lastName, id, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public List<Private> Privates { get; private set; }

        public void addPrivates(string id, List<IPrivate> allPrivates)
        {
            foreach (IPrivate item in allPrivates)
            {
                if (item.Id==id)
                {
                    this.privates.Add(item);
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Privates:");
            foreach (var pr in privates)
            {
                sb.AppendFormat(pr.ToString());
            }
            return base.ToString() + sb.ToString();

        }

    }
    
    }

