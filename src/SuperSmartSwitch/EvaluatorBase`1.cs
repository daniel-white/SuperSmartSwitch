using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSmartSwitch;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TResult>
    {
        protected EvaluatorBase()
        {
            Initialize();
        }
        private readonly IDictionary<IKey, TResult> _definitions = new Dictionary<IKey, TResult>();

        internal void Add<TKey>(TKey key, TResult result)
            where TKey : struct, IKey
        {
            _definitions.Add(key, result);
        }

        internal TResult Get<TKey>(TKey key)
            where TKey : struct, IKey
        {
            return _definitions.ContainsKey(key) ? _definitions[key] : default(TResult);
        }

        protected abstract void Initialize();
    }
}
