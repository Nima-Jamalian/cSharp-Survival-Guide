using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDB : MonoBehaviour
{
    public ListItemDataBase[] inventory = new ListItemDataBase[10];

    private ItemDB _itemDatabase;

    private void Start()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //request item by ID
            //har code adding item 0
            _itemDatabase.AddItem(0, this);
            //future worK: cehck for avilable inventory slots
        } else if (Input.GetKeyDown(KeyCode.R))
        {
            //remove item by ID
            _itemDatabase.RemoveItem(0,this);
        }
    }
}
