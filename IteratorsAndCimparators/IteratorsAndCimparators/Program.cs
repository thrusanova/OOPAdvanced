using IteratorsAndCimparators.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorsAndCimparators.models;

namespace IteratorsAndCimparators
{
    class Program
    {
        static void Main(string[] args)
        {
            var listFactory = new ListyFactory();
            var input = new Input(listFactory);
            input.Start();    
        }
    }
}
