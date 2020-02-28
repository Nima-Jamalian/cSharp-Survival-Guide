using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MyScript1 : MonoBehaviour
{
    //Creat a delegate of type int that returns the length of the gameObject names
    private Func<int> GetObjectCharacterLength;
    // Start is called before the first frame update
    void Start()
    {
        GetObjectCharacterLength = () => this.gameObject.name.Length;
        Debug.Log("Gameobject name character length is: " + GetObjectCharacterLength());//invoking GetObjectCharacterLength()
    }
}
