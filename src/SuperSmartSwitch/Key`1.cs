using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSmartSwitch
{
    internal struct Key<T> : IKey<T>
        where T : IEquatable<T>
    {
        public T Key1 { get; set; }
    }
}
