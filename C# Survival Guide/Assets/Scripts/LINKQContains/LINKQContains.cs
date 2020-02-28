using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINKQContains : MonoBehaviour
{
    //LINQ -> Language Integrated Query
    //Similiar to MySQL it allows us to filter through data specificly filter through array and lists
    private string[] names = { "jon", "alex", "julie", "jessi", "david", "marl", "matt" };
    // Start is called before the first frame update
    void Start()
    {
        //Any -> return a bool allows us to cycle through data. it's like a in line foreach loop using lambda expersion
        //syntax AnY(System.Func<string,bool>)
        //When working with link you use universal data var for storying it
        //var nameFound = names.Any(name => name == "jon");

        //Contains -> return bool that check wheater the input is in list or not
        var nameFound = names.Contains("jon");
        Debug.Log("NameFound: " + nameFound);

        //Not Using traditional method for loop
        //foreach(var name in names)
        //{
        //    if(name == "jon")
        //    {
        //        Debug.Log("Found " + name);
        //    }
        //}
    }
}
