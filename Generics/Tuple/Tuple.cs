using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace System
{

    /// <summary>
    /// Helper so we can call some tuple methods recursively without knowing the underlying types. 
    /// </summary>
    internal interface ITuple
    {
        string ToString(StringBuilder sb);
        int GetHashCode(IEqualityComparer comparer);
        int Size { get; }

    }

    public static class Tuple
    {
        public static Tuple<t1> Create<t1>(t1 item1)
        {
            return new Tuple<t1>(item1);
        }

        public static Tuple<t1, t2> Create<t1, t2>(t1 item1, t2 item2)
        {
            return new Tuple<t1, t2>(item1, item2);
        }

        public static Tuple<t1, t2, t3> Create<t1, t2, t3>(t1 item1, t2 item2, t3 item3)
        {
            return new Tuple<t1, t2, t3>(item1, item2, item3);
        }
    }
}
