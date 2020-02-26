using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTest//Instance Class
{
    //Instance members: Are created as copies, these variables are being copied everytime we creat a new item
    //when using instance member we we are creating instance of variable/method/class
    public string name;
    public int itemID;

    //static memeber: shared across all the instances(items), programme does NOT creat a new copies each time
    //when you have a static variable in instance class that variable is shared among all instances.
    public static int itemCount;//in memory indefinitely for the life of programme

    public ItemTest(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
        itemCount++;
    }
}

/*
//Example use of static memeber for multiplayer game
//Each time a new player is created we add 1 to connection count which is a staic member shared between all player gameobject
public class PlayerTest{
    public int id;
    public string name;

    public static int connectionCount;

    public PlayerTest()
    {
        connectionCount++;
    }
}
*/

public class InstanceVsStaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemTest sword = new ItemTest("Sword",1);
        ItemTest bread = new ItemTest("Bread",2);
        ItemTest cape = new ItemTest("cape",3);
        ItemTest fish = new ItemTest("fish",4);

        print("Item Count: " + ItemTest.itemCount);
        //only way to access the static data is directly though the class.
        //Example:
        //ItemTest.itemCount = 4;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
