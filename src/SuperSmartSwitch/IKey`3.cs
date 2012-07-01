using System;

namespace SuperSmartSwitch
{
    internal interface IKey<T1, T2, T3> : IKey<T1, T2>
        where T1 : IEquatable<T1>
        where T2 : IEquatable<T2>
        where T3 : IEquatable<T3>
    {
        T3 Key3 { get; set; }
    }
}