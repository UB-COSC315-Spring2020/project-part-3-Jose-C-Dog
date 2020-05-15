using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "InventorySystem/Inventory")]
public class InventoryObjects : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();

    public void AddItem(ItemObject givenObject, int givenAmount)
    {
        bool hasItem = false;

        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == givenObject)
            {
                hasItem = true;
                Container[i].AddAmount(givenAmount);
                break;
            }
        }
        if (!hasItem)
        {
            Container.Add(new InventorySlot(givenObject, givenAmount));
        }
    }
}
[System.Serializable]
public class InventorySlot
    {
    public ItemObject item;
    public int amount;

    public InventorySlot(ItemObject givenItem, int givenAmount)
        {
        item = givenItem;
        amount = givenAmount;
        }
    public void AddAmount(int value)
        {
        amount += value;
        }
 

}