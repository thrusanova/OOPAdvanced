using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CompareName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
           int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                var firstName = x.Name[0].ToString();
                var secondName = y.Name[0].ToString();

                result = firstName.CompareTo(secondName);
            }
return result;
        }
    }
}
