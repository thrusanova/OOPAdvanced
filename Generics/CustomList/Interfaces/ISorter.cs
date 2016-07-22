namespace CustomList.Interfaces
{
    using System.Collections.Generic;

    public interface ISorter<T>
    {
        void sort(List<T> myList);
    }
}
