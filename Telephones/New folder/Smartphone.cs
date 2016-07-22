using System;
using System.Linq;

namespace Telephones
{
    public class Smartphone : IBrowse, ICall
    {
        public Smartphone()
        {

        }

        public void Brouse(string url)
        {
            bool containsInt = url.Any(char.IsDigit);
            if (!containsInt && !string.IsNullOrEmpty(url))
            {
                Console.WriteLine("Browsing: " + url+"!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
         
                   
                  
           
        }

        public void Call(string number)
        {
            bool containsInt = number.Any(char.IsLetter);
            if (!containsInt && !string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Calling... " + number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            }
            
        }
    }

