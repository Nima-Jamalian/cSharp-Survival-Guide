using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MyScript : MonoBehaviour
{
    //Creat a delegate of type void that has no parameters and returns the gameObjects name
    private Action GetName;
    // Start is called before the first frame update
    void Start()
    {
        GetName = () => //when you have no input jut put empty ()
        {
            Debug.Log("Object name is: " + this.gameObject.name);
        };

        GetName();//invoking action GetName

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
