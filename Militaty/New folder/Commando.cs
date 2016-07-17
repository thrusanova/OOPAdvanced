using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;
        private string state;

        public Commando(string firstName, string lastName, string id, double salary,string crops) : base(firstName, lastName, id, salary,crops)
        {
            this.missions = new List<IMission>();
        }

        public void addMission(IMission mission)
        {
            if (mission.State!=null)
            {
                this.missions.Add(mission);
            }
        }

        public List<IMission> Missions()
        {
            return this.missions;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Missions: ");
            foreach (var pr in missions)
            {
                if (pr.State=="inProgress")
                {
                    sb.AppendFormat(pr.ToString());
                }
                
            }
            return base.ToString() + sb.ToString();
        }
    }
}
