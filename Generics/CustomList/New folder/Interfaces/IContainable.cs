using System;

namespace CustomList.Interfaces
{
    public interface IContainable<T> where T : IComparable, IAddable<T>, IRemovable<T>, IContainable<T>, ISwapable, IPrintable
    {
        bool contains(T element);
    }
}