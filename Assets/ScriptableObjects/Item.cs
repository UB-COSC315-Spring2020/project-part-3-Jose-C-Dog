using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    public ItemObject item;

    private void Awake()
    {
        if (item.image.Equals(null) || item.image.Equals(""))
        {
            Debug.LogWarning(item.name + "doesnt have image applied");
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = item.image;
    
    }


}
