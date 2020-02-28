using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesGameManager : MonoBehaviour
{
    /*
    private bool _isGameOver;
    //properties - You think of them as smart variables 
    //in Java properties are referred to as getter and setters 
    //Not only you can get information from them you can also run functionality through them  
    //Properties allows you to run and initialize codes directly through the variables.
    //Down side of properties you can not view them though the inspector - However you can see them though the inspector debug mode
    public bool IsGameOver
    {
        get
        {
            return _isGameOver;
        }
        private set
        {
            if(value == true)
            {
                Debug.Log("Oh No! The game is over!");
            }
            // = value automatically check whether the value type that is given is correct ot not
            _isGameOver = value;
        }
    }
    */



    //Auto Property
    //Down side we can not run functions though it - Also you can not view them though the inspector - However you can see them though the inspector debug mode
    //Up Side no need to have to variable (One for main variable and one for property)
    //You can also create accesses modifiers -> I have set the set to private  
    //Private: only this class can access it 
    //Protected: this class and all of this class inheritance can access it  
    //which means that every object in the game can read the value but only this class can set
    public bool IsGameOver { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        //_isGameOver = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
        }
        if(IsGameOver == true)
        {
            Debug.Log("Oh No! The game is over!");
        }
    }
    //No need to create Separate method anymore we can run codes through our properties  
    /*
    public void GameOver()
    {
        isGameOver = true;
        //Call UI Manager and Enable the over Screen.
    }
    */
}
