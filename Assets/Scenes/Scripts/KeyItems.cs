using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable Item", menuName = "InventorySystem/Items/KeyItems", order = 2)]
public class KeyItems : ItemObject
{
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}
