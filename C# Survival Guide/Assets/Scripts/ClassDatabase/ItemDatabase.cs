using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//delete : MonoBehaviour bauce we are not going to attach to a script
[System.Serializable]
public class ItemDatabase 
{
    public string name;
    public int id;
    public string description;

    //Note: You can have more than one constructor

    //constructor 1 
    public ItemDatabase()
    {

    }

    //constructor 2
    public ItemDatabase(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
