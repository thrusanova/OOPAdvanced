using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class Box<T>where T: IComparable<T>
    {

        private List<T> listOfItems;

        public Box()
        {
            this.listOfItems = new List<T>();
        }

        public void addItem(T element)
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

       
        public override string ToString()
        {
            var sb = new StringBuilder();
           foreach(T elem in listOfItems)
            {
                sb.AppendLine($"System.Int32: {elem}");
            }
            return sb.ToString();     
        }
   //     public virtual void PrintName(T input)
   //     {
      //      Console.Write($"{typeof(T).Name} ");
       // }
   


       
    }

   
}

