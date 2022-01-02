using System;
using UnityEngine;

namespace _Root.Scripts.Tools
{
    internal class SubscriptionProperty<T> : ISubscriptionProperty<T>
    {
        private T _value;
        private Action<T> _onChangeValue;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                _onChangeValue?.Invoke(_value);
            }
        }
        
        
        public void SubscribeOnChange(Action<T> subscriptionAction)
        {
            _onChangeValue += subscriptionAction;
        }

        public void UnsubscribeOnChange(Action<T> unSubscriptionAction)
        {
            _onChangeValue -= unSubscriptionAction;
        }
    }
}