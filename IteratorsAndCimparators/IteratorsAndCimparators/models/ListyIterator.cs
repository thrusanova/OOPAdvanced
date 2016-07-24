using IteratorsAndCimparators.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorsAndCimparators.models
{
    public class ListyIterator<T> : IlistyOperator<T>,IEnumerable<T>
     {
        private List<T> list;
        private int index = 0;
        public ListyIterator()
        {
            this.list = new List<T>();
            this.index = 0;
        }

     
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool hasNext()
        {
            if(this.list.Count > this.index + 1)
            {
                return true;
            }
            return false;
        }
       

        public bool Move()
        {
            if (this.index+1<this.list.Count)
            {
                this.index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine(this.list[this.index]);
        }

        IEnumerator IEnumerable.GetEnumerator( )
        {
            return this.GetEnumerator();
        }

        public int getSize()
        { 
         return  this.list.Count();
        }

    }
}
