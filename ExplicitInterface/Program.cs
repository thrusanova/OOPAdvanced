
using ExplicitInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line!="End")
            {
                string[] input = line.Split(' ');
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);
                IPerson citizen = new Citizen(name, country, age);
                Console.WriteLine(citizen.GetName());
                IResident citizens = new Citizen(name, country, age);
                Console.WriteLine(citizens.GetName());
                line = Console.ReadLine();
            }
        }
    }
}
