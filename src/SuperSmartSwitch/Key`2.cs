using System;

namespace SuperSmartSwitch
{
    internal struct Key<T1, T2> : IKey<T1, T2>
        where T1 : IEquatable<T1>
        where T2 : IEquatable<T2>
    {
        public T1 Key1 { get; set; }
        public T2 Key2 { get; set; }
    }
}