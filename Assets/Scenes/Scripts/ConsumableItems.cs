using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable Item", menuName = "InventorySystem/Items/Consumable", order = 0)]
public class ConsumableItems : ItemObject
{
    public int healthRegen;
    public int hygieneRegen;
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}
