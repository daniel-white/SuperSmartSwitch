using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSmartSwitch
{
    internal interface IKey<T> : IKey
        where T : IEquatable<T>
    {
        T Key1 { get; set; }
    }
}
