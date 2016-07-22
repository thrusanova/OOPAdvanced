

namespace CustomList
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class newList<T> where T:IComparable
    {
    private List<T> listOfItems;
        public newList()
        {
            this.listOfItems = new List<T>(); ;
        }
        public void Add(T element)
        {
            this.listOfItems.Add(element);
        }

        public T this[int index]
        {
            get
            {
                return this.listOfItems[index];
            }
            set
            {
                this.listOfItems[index] = value;
            }
        }
        public void remo(int index)
        {
            this.listOfItems.Remove(this.listOfItems[index]);
        }
        public Boolean Contains(T element)
        {
            if (this.listOfItems.Contains(element))
            {
                return true;
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = listOfItems[firstIndex];
           this.listOfItems[firstIndex] = this.listOfItems[secondIndex];
            this.listOfItems[secondIndex] = temp;
        }
     public int CountGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i].CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            return this.listOfItems.Max();
        }
        public T Min()
        {
            return this.listOfItems.Min();
        }
        public void Print()
        {
            foreach (T item in listOfItems)
            {
                Console.WriteLine(item);
            }
        }
        public void sort()
        {
            
              listOfItems.Sort();
             }
           }
    }

