using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var list = new newList<string>();
            while (input != "END")
            {
                string[] line = input.Split(' ');
                string command = line[0];
                switch (command)
                {
                    case "Add":
                        list.Add(line[1]);
                        break;
                    case "Remove":
                        list.remo(int.Parse(line[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(line[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(line[1]), int.Parse(line[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(line[1]));
                        break;
                    case "Max": Console.WriteLine(list.Max());break;
                    case "Min": Console.WriteLine(list.Min());break;
                    case "Print":list.Print();break;
                   case "Sort":list.sort();break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
