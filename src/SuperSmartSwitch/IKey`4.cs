using System;

namespace SuperSmartSwitch
{
    internal interface IKey<T1, T2, T3, T4> : IKey<T1, T2, T3>
        where T1 : IEquatable<T1>
        where T2 : IEquatable<T2>
        where T3 : IEquatable<T3>
        where T4 : IEquatable<T4>
    {
        T4 Key4 { get; set; }
    }
}