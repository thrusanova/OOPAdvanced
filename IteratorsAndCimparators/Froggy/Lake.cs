using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{



    public class Lake : IEnumerable<long>
    {
        private List<long> path;
        public Lake(List<long> path)
        {
            this.path = path;
        }
        
        public IEnumerator<long> GetEnumerator()
        {
           
            for (int i = 0; i < path.Count; i += 2)
            {
                yield return this.path[i];
              
            }
            int lastIdex = 0;
            if (this.path.Count %2==0)
            {
                lastIdex = this.path.Count - 1;
            }
            else
            {
                lastIdex = this.path.Count - 2;
            }
           for (int i = lastIdex; i >= 0 ; i-=2)
            {
                yield return this.path[i];
            }
           
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    
    }

