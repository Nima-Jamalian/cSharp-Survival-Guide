using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Pet
{
    protected override void Speak()
    {
        //calling base fucntion 
        //base.Speak();
        Debug.Log("Quack Quack!");
    }

}
