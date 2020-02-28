using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    
    public int east;
    public int noraml;
    public int hard;
    public int currentSelectedLevel;
    

    public enum LevelSelector
    {
        Easy,//0
        Normal,//1
        Hard,//2
        Expert//3
        //You can also assign custom number you names if you want 
        /*
        Easy = 0,//0
        Normal = 56,//1
        Hard = 42,//2
        Expert = 23//3
        */
    }

    public LevelSelector currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        if(currentLevel == LevelSelector.Easy)
        {
            Debug.Log("You Selected Easy.");
        }
        //You can also use a switch statement
        /*
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
