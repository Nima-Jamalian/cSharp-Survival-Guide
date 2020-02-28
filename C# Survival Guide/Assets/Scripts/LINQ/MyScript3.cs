using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;//inorder to use link we need to import this library 
public class MyScript3 : MonoBehaviour
{
    //LINQ -> Language Integrated Query
    //Similiar to MySQL it allows us to filter through data specificly filter through array and lists
    private string[] names = { "jon", "alex", "julie", "jessi", "david", "marl", "matt" };
    // Start is called before the first frame update
    void Start()
    {
        //Any -> return a bool allows us to scyle though data. it's like a in line foreach loop using lambda expersion
        //syntax AnY(System.Func<string,bool>)
        //When working with link you use universal data var for storying it
        var nameFound = names.Any(name => name == "jon");
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
