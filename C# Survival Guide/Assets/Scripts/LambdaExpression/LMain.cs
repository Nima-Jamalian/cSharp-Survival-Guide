using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LMain : MonoBehaviour
{
    //Creat a program that takes in a string and return the length of it. (How many characters)
    //public delegate string OnComplete;

    //Using Delegate
    //public delegate int CharacterLength(string text);
    //CharacterLength cl;

    //Using Func
    public Func<string, int> MyCharacterLength;//<input,out put>

    // Start is called before the first frame update
    void Start()
    {
        //Lambda Operator
        //the programme know name is type string base on func input which is <string>
        MyCharacterLength = (name) => name.Length;
        Debug.Log(MyCharacterLength("Nima"));
    }






    //int GetCharacters(string name)
    //{
    //    return name.Length;
    //}
}
