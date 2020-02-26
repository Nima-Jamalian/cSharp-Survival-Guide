using System.Collections;
using System.Collections.Generic;//list, ditonaries
using UnityEngine;

/*
Dictionaries are unique to list they are associated by key value per.
In list we push objects in it and sort though it.

With a dictionaries you association with a key value per.

keys must be unique, value can have duplicate

keys also must exist otherwise you would get an error.

dictionaries do not appear in the inspector, they don’t even appear  in the debug mode 

//When to use dictonaries:
//Great when you are working with larg list
Example: for a RPG game shop market where you have a lot of items
If a user buys something if you are using a list you need to compare the id and see what they are buying,
if you use dictionaries then you have a key value pair mapped to an item you don't need to iterate though
we already know which item is associated with the key.
*/
public class ItemDictonary : MonoBehaviour
{
    //List
    //public List<ItemD> listDatabase = new List<ItemD>();
    //Dictionary
    public Dictionary<int, ItemD> dictonaryDatabase = new Dictionary<int, ItemD>();
    //Start is called before the first frame update
    void Start()
    {
        //listDatabase.Add(new ItemD());//adding item to list
        //dictonaryDatabase.Add(0, new ItemD());//adding item to dictonary
        ItemD sword = new ItemD();
        sword.name = "Sword";
        sword.id = 0;
        //adding item sword to dictonary
        dictonaryDatabase.Add(0, sword);

        ItemD bread = new ItemD();
        bread.name = "Bread";
        bread.id = 1;
        dictonaryDatabase.Add(1, bread);

        ItemD cape = new ItemD();
        cape.name = "Cape";
        cape.id = 2;
        dictonaryDatabase.Add(2, cape);

        //all possible ways
        foreach(var item in dictonaryDatabase)
        {
            print(item.Key + item.Value.name);
        }
        
        foreach(KeyValuePair<int,ItemD> item in dictonaryDatabase)
        {
            Debug.Log("Key: " + item.Key + " Value: " + item.Value.name);
        }

        foreach(int key in dictonaryDatabase.Keys)
        {
            Debug.Log("Key: " + key);
        }

        foreach (ItemD item in dictonaryDatabase.Values)
        {
            Debug.Log("Key: " + item.name);
        }


        //Code bellow: Would give you an error KeyNotFoundException: The given key was not present in the dictionary.
        //var randomItem = dictonaryDatabase[69];

        //Inorder to avoid this error we can check whether the key exist or not at first
        //and the try to access it
        if (dictonaryDatabase.ContainsKey(69))
        {
            Debug.Log("You found the key!");
            var randomItem = dictonaryDatabase[69];
        } else
        {
            Debug.Log("Key does not exist");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
