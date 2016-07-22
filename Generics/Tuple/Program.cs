using System;
using System.Text.RegularExpressions;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = Console.ReadLine();
            var firstLine= Regex.Split(f, "\\s+");
            string fullName = firstLine[0] + " " + firstLine[1];
            string address = firstLine[2];
            string town = firstLine[3];
            var person = new Tuple<string,string,string>(fullName, address,town);
            Console.WriteLine($"{person.Item1} -> {person.Item2} -> {person.Item3}");
            var s = Console.ReadLine();
            var secondLine = Regex.Split(s, "\\s+");
            var name = secondLine[0];
            var litres = int.Parse(secondLine[1]);
            bool drunk = false;
            if (secondLine[2]=="drunk")
            {
                drunk = true;
            }
            else
            {
                drunk = false;
            }
            var beer = new Tuple<string, int,bool>(name, litres,drunk);
            Console.WriteLine($"{beer.Item1} -> {beer.Item2} -> {beer.Item3}");
            var n = Console.ReadLine();
            var thirdLine = Regex.Split(n, "\\s+");
            var integerNumber = (thirdLine[0]);
            var doubleNumber = double.Parse(thirdLine[1]);
            var curr = thirdLine[2];
            var number = new Tuple<string, double,string>(integerNumber, doubleNumber,curr);
            Console.WriteLine($"{integerNumber} -> {doubleNumber} -> {curr}");
        }
    }
}
