using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RMain : MonoBehaviour {

    //Creat a program that takes in a string and return the length of it. (How many characters)
    //public delegate string OnComplete;

    //Using Delegate
    //public delegate int CharacterLength(string text);
    //CharacterLength cl;

    //Using Func
    public Func<string, int> CharacterLength;//<input,out put>

    // Start is called before the first frame update
    void Start()
    {
        //Using Delegate
        //cl = GetCharacters;
        /*
         * CharacterLength cl = new CharacterLength(GetCharacters);
         * is same as saying
         * CharacterLength cl;
         * cl = GetCharacters;
         * another way of coding it 
         */
        //Debug.Log(cl("Nima"));


        //Using Func
        CharacterLength = GetCharacters;
        Debug.Log(CharacterLength("Nima"));

        //Normal implementation not using delegate
        //int characterCount = GetCharacters("Nima");
        //Debug.Log("Character Count: " + characterCount);
    }
    int GetCharacters(string name)
    {
        return name.Length;
    }
}
