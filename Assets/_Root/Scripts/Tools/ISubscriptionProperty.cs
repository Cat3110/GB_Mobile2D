using System;

namespace _Root.Scripts.Tools
{
    internal interface ISubscriptionProperty<T>
    {
        T Value { get; }
        void SubscribeOnChange(Action<T> subscriptionAction);
        void UnsubscribeOnChange(Action<T> unSubscriptionAction);
    }
}