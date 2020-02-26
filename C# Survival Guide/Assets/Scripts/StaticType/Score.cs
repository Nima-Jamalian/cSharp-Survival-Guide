using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //public int score;
    //static
    //the data is going to be in the same memory location for life of your programme
    //even if you delte it, the data will remain
    //static types variables are stored indefinitely in your memory.
    //You are not able to see static variables in the inspector
    //When you using static types you need to remeber that your data will be in memory for the life of your programme
    //Keep that in mind when creating large application, are you running out of memmory space and need to free up memmory.
    public static int score;

    //anything can be static
    public static void AddScore()
    {

    }

    //even your class can be static however if your class is static you can not inherate anything.
    /*
    public static class Score : MonoBehaviour
    {

    }
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
