using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food Item", menuName = "InventorySystem/Items/FoodItems", order = 1)]
public class FoodItems : ItemObject

{
    public int healthRegen;
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}
