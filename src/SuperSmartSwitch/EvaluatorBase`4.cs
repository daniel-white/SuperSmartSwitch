using System;

namespace SuperSmartSwitch
{
    public abstract class EvaluatorBase<TKey1, TKey2, TKey3, TResult> : EvaluatorBase<TKey1, TKey2, TResult>
        where TKey1 : IEquatable<TKey1>
        where TKey2 : IEquatable<TKey2>
        where TKey3 : IEquatable<TKey3>
    {

        protected void Add(TResult result, TKey1 key1, TKey2 key2, TKey3 key3)
        {
            var keyStruct = new Key<TKey1, TKey2, TKey3> { Key1 = key1, Key2 = key2, Key3 = key3, };
            Add(keyStruct, result);
        }
    }
}