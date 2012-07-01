using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TKey, TResult>
        where TKey : IEquatable<TKey>
    {
        private readonly IDictionary<IKey, TResult> _definitions = new Dictionary<IKey, TResult>();

        internal void Add(IKey keyValue, TResult result)
        {
            _definitions.Add(keyValue, result);
        }

        protected void Add(TResult result, TKey key)
        {
            var keyStruct = new Key<TKey> { Key1 = key };

            Add(keyStruct, result);
        }
    }
}
