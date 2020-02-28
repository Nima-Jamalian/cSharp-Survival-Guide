using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Struct are immutable 
//Meaning they don't change 
//so they can't have inheritance
//Struc is a value type
//Struck improves performance very slightly, However you should Not to look at as a way to improve performance
//Use if you have fewer than 4 fields/elements(variable) and you do not need to inherit from it.
public struct MyItem2// VALUE TYPE --> Stored on Stack
{
    public string name;
    public int itemID;

    public MyItem2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

//Class
//Supports Inheritance
public class MyItem// REFERENCE TYPE --> Stored on Heap
{
    public string name;
    public int itemID;

    public MyItem(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class StructTest : MonoBehaviour
{
    private MyItem _sword;
    private MyItem2 _bread;

    // Start is called before the first frame update
    void Start()
    {
        //for class you use the word new (instance of an object)
        //because it is a reference type.
        _sword = new MyItem("Sword", 1);

        //when using struct you do not need to use new (instance of an object)
        //because it's a value type
        _bread.name = "Bread";
        _bread.itemID = 2;
        //You can also initialize it like below
        //_bread = new MyItem2("Bread", 2);  

        Debug.Log("Sword Current Name: " + _sword.name);

        Debug.Log("ChanageValue(_sword);");
        ChanageValue(_sword);

        Debug.Log("Sword Current Name (After method): " + _sword.name);

        Debug.Log("Current Bread Name: " + _bread.name);

        ChanageValue(_bread);
        Debug.Log("Bread name (After method): " + _bread.name);

        //Value type: a data type is a value type if it holds a data value within its own memory space.
        //it means variable of these data type directly contain their value.
        //Anything that has associated value.
        //Example: bool, bytes, char, doubles, float, int, long, structs
        //When you pass a value type into a method, programme would copy or clone the value but you can not change the original value

        /*
         * Reference type:Unlike value type, a reference type does not store it's value directly instead
         * store the address of where the value is being stored in other words a reference type contains a pointer
         * to another memory location that holds the data
         * Example: string, all arrays, classes, delegates
         * When you pass a reference type into a function, you maintain the reference to object and original value and you can modify it
        */


        /*
         * Memory Management in C#
         In C# memory management handel by language it self.
         C# has built in garbage collection. So we do not need to worry about pointers.
         However not all programming languages do this automatically for example. C++ does not have
         built in memory management. So you will be working with pointer a lot of time.
         */
    }

    void ChanageValue(MyItem2 structItem)//Value Type
    {
        Debug.Log("ChanageValue(MyItem2 structItem) Called for Bread Change Name");
        /*
        * This will not change the name
        * because this is a value type
        * we made copy of original value and we can not modify the original value 
        */
        structItem.name = "Dirty Bread";
    }

    void ChanageValue(MyItem classItem)//Referenced Type
    {
        /*
        * This will change the name
        * because this is a reference type
        * we can modify the original value only when we have access to the original value (reference)
        */
        classItem.name = "Master Sword";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
