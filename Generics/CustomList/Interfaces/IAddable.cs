using System;

namespace CustomList.Interfaces
{
    public interface IAddable<T> where T : IComparable, IAddable<T>, IRemovable<T>, IContainable<T>, ISwapable, IPrintable
    {
        void add(T element);
    }
}