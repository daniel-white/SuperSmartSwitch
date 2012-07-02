using System;

namespace SuperSmartSwitch
{
    public interface IEvaluator<TKey, TResult> 
        where TKey : IEquatable<TKey>
    {
        TResult Evaluate(TKey key);
    }
}