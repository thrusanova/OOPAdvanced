using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCimparators.interfaces
{
  public interface IlistyOperator<T>
    {
        bool Move();

        bool hasNext();

        void Print();

        int getSize();

    }
}
