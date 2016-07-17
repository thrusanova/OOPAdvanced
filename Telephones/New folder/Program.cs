using System;

namespace Telephones
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] urls = Console.ReadLine().Split(' ');
            var phone = new Smartphone();
            foreach (var number in numbers)
            {
                phone.Call(number) ; 
            }
            foreach (var url in urls)
            {
                phone.Brouse(url);
            }
        }
    }
}
