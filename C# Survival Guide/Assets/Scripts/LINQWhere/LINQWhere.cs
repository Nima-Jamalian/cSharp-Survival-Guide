using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINQWhere : MonoBehaviour
{
    /*
    LINKQ - Where (Important)
    Allows us to sort an existing collection and create a new collection based on some condition.
    For Example:
    Let's say in the array of name bellow I wanted to select or creat a list of names that are only greater
    than five character long. We can use Where to achive this.
    */

    [SerializeField] private string[] names = { "jon", "jon", "julie", "alex", "julie", "jessie", "david", "mark", "batista" };
    // Start is called before the first frame update
    void Start()
    {
        var namesWithMoreThanFiveCharacter = names.Where((names) => names.Length > 5);
        foreach(var name in namesWithMoreThanFiveCharacter)
        {
            print(name);
        }
    }
}
