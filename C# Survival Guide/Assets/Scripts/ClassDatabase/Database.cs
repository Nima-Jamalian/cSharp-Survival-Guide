using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public ItemDatabase _sword;
    public ItemDatabase _hammer;
    //creating empty variable
    public ItemDatabase _gun;

    //Creating an array of data base and assigning it through inspector
    public ItemDatabase[] inventory;

    // Start is called before the first frame update
    void Start()
    {
        //creating class object and assinging it without using constructor or empty constructor
        _sword = new ItemDatabase();
        _sword.name = "Sowrd";
        _sword.id = 1;
        _sword.description = "This is a sword!";

        //creating class and assiging it using constrcutore
        _hammer = new ItemDatabase("Hammer", 2, "This is a hammer.");

       
        //Creating new item using our custom method
        //only creat a new object based on the class however we can not acsses it 
        //CreatItem("Gun", 3, "This is a gun.");

        //Creating new item using our custom method
        //we are creating a new object based on the class and we are returning the item
        //and assigne it to the object we created so we can acsses it later on
        _gun = CreatItem("Gun", 3, "This is a gun.");

        //acssesing the array
        print(inventory[0].name + " is the id = 4 and element 0 of invetory array.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creating a method for creating item using constructor
    //The mthod is a return so we can acsses the item latter on.
    private ItemDatabase CreatItem(string name, int id, string description)
    {
        var item = new ItemDatabase(name, id, description);

        return item;
    }
}
