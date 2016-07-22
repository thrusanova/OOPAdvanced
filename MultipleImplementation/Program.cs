using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplementation
{

    class Program
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            var car = new Ferrary(driver);
            Console.WriteLine($"{car.Model}/{car.UseBrakes()}{car.PushTheGas()}/{car.Driver}");
        }
    }
}
