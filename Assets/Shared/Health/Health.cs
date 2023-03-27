using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class BaseValueClass
    {
        public float Value { get; protected set; }
        protected float _maxValue;

        protected BaseValueClass(float initialValue, float maxValue)
        {
            Value = initialValue;
            _maxValue = maxValue;
        
            Debug.Log("Base");
        }

        public virtual void AddValue(float value)
        {
            Value += value;
        }

        public virtual void SetValue(float value)
        {
            Value = value;
        }

        public virtual void ChangeMaxValue(float newValue)
        {
            _maxValue = newValue;
        }
    }

    [Serializable]
    public class Health : BaseValueClass
    {
        public Action OnDie = delegate {  };

        public override void AddValue(float value)
        {
            base.AddValue(value);

            if (!(Value <= 0)) return;
        
            Value = 0;
            
            OnDie?.Invoke();
        }

        public Health(float initialValue, float maxValue) : base(initialValue, maxValue)
        {
            Debug.Log("Value");
        }
    }
}
