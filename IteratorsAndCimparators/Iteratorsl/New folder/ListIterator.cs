using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteratorsl
{

    public class ListyIterator<T> : IEnumerable<T>
        {
            private List<T> list;
            private int index = 0;
            public ListyIterator()
            {
                this.list = new List<T>();
                this.index = 0;
            }

        public void Create(List<T> elements)
        {
            this.list = new List<T>();
            this.list.AddRange(elements);
            index = 0;
        }
      
            public bool hasNext()
            {
                if (this.list.Count > this.index + 1)
                {
                    return true;
                }
                return false;
            }


            public bool Move()
            {
                if (this.index + 1 < this.list.Count)
                {
                    this.index++;
                    return true;
                }
                return false;
            }

            public void Print()
            {
                try
                {
                    Console.WriteLine(this.list[this.index]);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
            }
        public void PrintAll()
        {
            try
            {
                foreach (var item in list)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    }
