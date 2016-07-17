using System;
using System.Collections.Generic;


namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var citizens = new List<Citizen>();
            var rebels = new List<Rebel>();
            for (int i = 0; i < numbers; i++)
            {
                string line = Console.ReadLine();
                string[] input = line.Split(' ');
                    if (input.Length == 4)
                    {
                        var citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
                        citizens.Add(citizen);
                    citizen.buyFood();
                    }
                    else if (input.Length == 3)
                    {
                         var rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                         rebels.Add(rebel);
                    rebel.buyFood();
                    }
            }
            string name = Console.ReadLine();
            int food = 0;
            while (name!="End")
            {
                foreach (var cit in citizens)
                {
                    if (cit.Name==name)
                    {
                        food += cit.Food;
                    }
                }

                foreach (var reb in rebels)
                {
                    if (reb.Name == name)
                    {
                        food += reb.Food;
                    }
                }
                name = Console.ReadLine();
            }

            Console.WriteLine(food); 
        }
    }
}
