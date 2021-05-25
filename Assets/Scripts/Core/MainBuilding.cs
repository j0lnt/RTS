using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectableItem
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    [SerializeField] private EventSystem _eventSystem;

    private float _health = 1000;

    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }
    
    public void Update()
    {
        if (_eventSystem.IsPointerOverGameObject()) ;
    }
}
