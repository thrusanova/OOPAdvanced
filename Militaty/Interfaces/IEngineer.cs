using System.Collections.Generic;


namespace Militaty.Interfaces
{
  public  interface IEngineer
    {
        List<IRepair>getRepairs { get; }

        void addRepair(string partName, int hoursWorked);

    }
}
