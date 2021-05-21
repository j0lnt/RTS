using UnityEngine;

namespace Abstractions
{
    public interface ISelectableItem
    {
        float Health { get; }
        float MaxHealth { get; }
        Sprite Icon { get; }
    }
}