using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObject
    {
        public ISelectableItem CurrentValue { get; private set; }
        public ISelectableItem Value { get; set; }

        public Action<ISelectableItem> OnSelected;

        public void SetValue(ISelectableItem value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }
    }
}