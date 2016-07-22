using CustomList.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Interfaces
{
   
        public interface ICustomList<T>where T: IComparable ,IAddable<T>, IRemovable<T>, IContainable<T>, ISwapable,ISorter<T>,
        IPrintable {

            int CountGreaterThan(T element);

            T Max();

            T Min();

           // int Size();

           // T get(int index);
        }
    }

