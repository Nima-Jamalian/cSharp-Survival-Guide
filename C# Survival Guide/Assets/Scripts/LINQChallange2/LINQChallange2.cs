using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class MyItem8
{
    public string name;
    public int itemID;
    public int buff;
}

public class LINQChallange2 : MonoBehaviour
{
    public List<MyItem8> myItem8;
    /*
    Check if ItemID 3 exist in the list and print out true or false
    Grab all items with buff greater than 20 and print them out
    calculate the average of all the buff stats
     */
    // Start is called before the first frame update
    void Start()
    {
       var result = myItem8.Any(myItem8 => myItem8.itemID == 3);
       Debug.Log("Does Item ID 3 exist, Result: " + result);

       var resultBuff = myItem8.Where(myItem8 => myItem8.buff > 20);
       Debug.Log("Item with buff higher than 20:");
       foreach (var item in resultBuff)
       {
            print(item.name);
       }

       //.Average For Getting Average
       var average = myItem8.Average(myItem8 => myItem8.buff);
       Debug.Log("Average: " + average);
    }
}
