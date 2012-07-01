using System;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TKey1, TKey2, TResult> : EvaluatorBase<TKey1, TResult>
        where TKey1 : IEquatable<TKey1>
        where TKey2 : IEquatable<TKey2>
    {

        protected void Add(TResult result, TKey1 key1, TKey2 key2)
        {
            var keyStruct = new Key<TKey1, TKey2> { Key1 = key1, Key2 = key2 };
            Add(keyStruct, result);
        }
    }
}