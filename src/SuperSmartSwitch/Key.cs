using System;

namespace SuperSmartSwitch
{
    internal struct Key<T1, T2, T3> : IKey<T1, T2, T3>
        where T1 : IEquatable<T1>
        where T2 : IEquatable<T2>
        where T3 : IEquatable<T3>
    {
        public T1 Key1 { get; set; }
        public T2 Key2 { get; set; }
        public T3 Key3 { get; set; }
    }
}