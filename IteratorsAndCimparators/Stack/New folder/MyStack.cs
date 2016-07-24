
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteratorsl
{
    public class MyStack<T> : IEnumerable<T>
    {
        public List<T> stack;

        public MyStack()
        {
            this.stack = new List<T>();
        }
        public void Push(List<T>items)
        {
            foreach (var item in items)
            {
                this.stack.Add(item);
            } 
        }
        public void Pop()
        {
            if (stack.Count>0)
            {
                stack.Remove(stack[stack.Count - 1]);
            }
            else
            {
                Console.WriteLine("No elements");
            }
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stack.Count-1; i >=0; i--)
            {
                yield return this.stack[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
