using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<ListItemDataBase> itemDataBase = new List<ListItemDataBase>();

    public void AddItem(int itemID, PlayerDB playerDB)
    {
        //check if item matches somwthing in the database
        foreach(var item in itemDataBase)
        {
            if(item.id == itemID)
            {
                Debug.Log("We have a mathc!");
                playerDB.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item Does not exist");
    }

    public void RemoveItem(int ItemID, PlayerDB playerDB)
    {
        foreach(var item in itemDataBase)
        {
            if(item.id == ItemID)
            {
                playerDB.inventory[0] = null;
            }
        }
    }
}
