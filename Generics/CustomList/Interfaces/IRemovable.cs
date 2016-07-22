using System;

namespace CustomList.Interfaces
{
    public interface IRemovable<T> where T : IComparable, IAddable<T>, IRemovable<T>, IContainable<T>, ISwapable, IPrintable
    {
        void remove(T element);
    }
}