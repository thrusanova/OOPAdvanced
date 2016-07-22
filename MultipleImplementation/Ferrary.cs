using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplementation
{
    public class Ferrary : ICar
    {
       // private string driver;

        public string Model { get; }

        public string Driver { get; private set; }


        public Ferrary()
        {
            this.Model = "488-Spider";
            //this.driver = driver; 
        }
        public Ferrary(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver; 
        }



        public string PushTheGas()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
        
    }
}
