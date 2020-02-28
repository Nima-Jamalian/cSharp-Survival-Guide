using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINKQQuery : MonoBehaviour
{
    int[] scores = new int[] { 97, 92, 81, 60 };
    // Start is called before the first frame update
    void Start()
    {
        //quary syntax 
        var scoreQuereSyntax =
            from score in scores
            where score > 80
            select score;//the main differance between the quary syntax and method syntax is that
                         //the quary syntax requires the select keyword, the method syntax does not

        foreach (var score in scoreQuereSyntax)
        {
            Debug.Log("Score: " + score);
        }

        //method syntax  
        var scoreMethodSyntax = scores.Where(scores => scores > 80);
        foreach(var score in scoreMethodSyntax)
        {
            Debug.Log("Score: " + score);
        }
    }
}
