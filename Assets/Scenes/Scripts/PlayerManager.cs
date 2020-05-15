using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this attaches to the player
public class PlayerManager : MonoBehaviour
{
    public InventoryObjects inventory;
    public DisplayInventory displayInventory;


    public void OnTriggerEnter(Collider collision)
    {
        var item = collision.GetComponent<Item>();

        if (item)
        {
            inventory.AddItem(item.item, 1);
            //where the item actually is
            Destroy(collision.gameObject);
            displayInventory.UpdateDisplay();

        }
        
        Debug.Log("Touched the Item");
    }
    public void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}

