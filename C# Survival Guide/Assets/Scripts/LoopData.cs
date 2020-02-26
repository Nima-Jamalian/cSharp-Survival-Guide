using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inorder to see the vraibles in the Inspector
[System.Serializable]
public class Item
{
    //if you want to acsses vriable from another ascript they need to be set as public
    public int itemID;
    public string name;
    public string description;
}

public class LoopData : MonoBehaviour
{
    [SerializeField] private Item[] _myItems;

    void Start()
    {
        foreach (var item in _myItems)
        {
            print(item.name);
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, _myItems.Length);
            print(_myItems[randomID].name + " " +_myItems[randomID].description);
        }
    }
}
