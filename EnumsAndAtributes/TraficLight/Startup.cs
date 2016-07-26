using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficLight
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var trafficLights = new List<TraficLight>();
            var enumsLen = Enum.GetNames(typeof(Color)).Length;
            for (int i = 0; i < input.Length; i++)
            {
                var color = Enum.Parse(typeof(Color),input[i]);
                var traficLight = new TraficLight((Color)color);
                trafficLights.Add(traficLight);
            }
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                ChangeLight(trafficLights, enumsLen);
                Console.WriteLine(string.Join(" ",trafficLights));
            }
        }

        private static List<TraficLight> ChangeLight(List<TraficLight> trafficLights, int enumsLen)
        {
            foreach (var item in trafficLights)
            {
                item.Color=(Color)(((int)item.Color+1)%enumsLen);
            }
            return trafficLights;
        }
    }
}
