using System;
using UnityEngine;
using UnityEngine.Events;
using  T = System.String;

namespace PolyPerfect.Crafting.Integration
{
    public class CategoryStringUser : CategoryValueUser<T>
    {
        [SerializeField] TEvent Event;
        public override string __Usage => "Easy usage of text data from items put in the attached ItemSlotComponent.";

        void OnValidate()
        {
            if (!(Category is BaseCategoryWithData<T>))
                Category = null;
        }

        protected override void SendChange(T value)
        {
            Event.Invoke(value);
        }

        [Serializable]
        class TEvent : UnityEvent<T>
        {
        } //necessary for Unity 2019 compatibility
    }
}