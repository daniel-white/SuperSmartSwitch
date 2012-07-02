using System;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TKey1, TKey2, TResult> : EvaluatorBase<TKey1, TResult>
        where TKey1 : IEquatable<TKey1>
        where TKey2 : IEquatable<TKey2>
    {

        protected void Add(TResult result, TKey1 key1, TKey2 key2)
        {
            Add(CreateKey(key1, key2), result);
        }

        public TResult Evaluate(TKey1 key1, TKey2 key2)
        {
            var result = Get(CreateKey(key1, key2));

            if (!object.Equals(result, default(TResult)))
            {
                return result;
            }

            return Evaluate(key1);
        }

        internal Key<TKey1, TKey2> CreateKey(TKey1 key1, TKey2 key2)
        {
            return new Key<TKey1, TKey2> { Key1 = key1, Key2 = key2 };
        }
    }
}