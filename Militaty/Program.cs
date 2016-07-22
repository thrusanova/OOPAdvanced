using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit militaryUnit = new MilitaryUnit();
            Commands commandDispatcher = new Commands(militaryUnit);

            commandDispatcher.process();
        }
    }
}
