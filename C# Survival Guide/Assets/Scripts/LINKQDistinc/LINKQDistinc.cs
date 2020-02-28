using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINKQDistinc : MonoBehaviour
{
    [SerializeField] private string[] names = { "jon","jon","julie", "alex", "julie", "jessi", "david", "mark", "matt" };
    // Start is called before the first frame update
    void Start()
    {
        /*
        Distinc - removes all dublicates ellements from collection and return only distinc
        or unique element then it creats a new collection which is type of list which we can use.
        */
        //Distinct() -> return a collection of unique  elements  
        var uniqueNames = names.Distinct();
        foreach(var name in uniqueNames)
        {
            Debug.Log("Name: " + name);
        }
    }
}
