using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TKey, TResult> : EvaluatorBase<TResult>, IEvaluator<TKey, TResult> 
        where TKey : IEquatable<TKey>
    {
        protected void Add(TResult result, TKey key)
        {
            Add(CreateKey(key), result);
        }

        public TResult Evaluate(TKey key)
        {
            return Get(CreateKey(key));
        }

        internal Key<TKey> CreateKey(TKey key)
        {
            return new Key<TKey> { Key1 = key };
        }
    }
}
