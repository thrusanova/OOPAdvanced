using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Iteratorsl
{

    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var list = new ListyIterator<string>();
            while (line!="END")
            {
                var firstLine = Regex.Split(line, "\\s+");
                string command = firstLine[0].Trim();
                switch (command)
                {
                    case "Create":
                        var collection = new List<string>();
                        for (int i = 1; i < firstLine.Length; i++)
                        {
                            collection.Add(firstLine[i]);
                        }
                        list.Create(collection);
                        break;
                    case "Move":
                        Console.WriteLine(list.Move()); ; break;
                    case "HasNext":
                        Console.WriteLine(list.hasNext()); ; break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        };break;
                    case "PrintAll":
                        try
                        {
                            list.PrintAll();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }; break;

                    default:
                        break;
                }
                line=Console.ReadLine();
            }
        }
    }
}
