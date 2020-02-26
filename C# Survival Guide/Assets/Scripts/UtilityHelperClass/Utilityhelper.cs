using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When the class is static we can no longer inherit from anything
//Meaning we can not also use the MonoBehavior class and attach the script to objects

//Everything must be static in order for it to work (variables,methods, etc.)
public static class Utilityhelper
{

    //public int myAge;//Gives Error because it is not a static variable
    public static int myAge;

    /*
    public void CreatObject()//Gives Error because it is not a static method
    {

    }
    */
    public static void CreatObject()
    {
        //Creat a new primitive cube
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        //change position of obj
        obj.transform.position = Vector3.zero;
    }
}
