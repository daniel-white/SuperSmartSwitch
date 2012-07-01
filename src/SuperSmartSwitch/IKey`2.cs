using System;

namespace SuperSmartSwitch
{
    internal interface IKey<T1, T2> : IKey<T1>
        where T1 : IEquatable<T1>
        where T2 : IEquatable<T2>
    {
        T2 Key2 { get; set; }
    }
}