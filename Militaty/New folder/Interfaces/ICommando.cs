using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty.Interfaces
{
   public interface ICommando
    {

        List<IMission> Missions();

        void addMission(IMission mission);
      
    }
}
