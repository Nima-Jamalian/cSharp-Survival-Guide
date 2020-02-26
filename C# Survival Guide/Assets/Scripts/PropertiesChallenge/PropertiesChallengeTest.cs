using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Testing
{
    PropertiesChallengeTest test = new PropertiesChallengeTest();

    public Testing()
    {
        test.Name = "Nima";
        Debug.Log("The speed is" + test.Speed);
    }
}
*/

public class PropertiesChallengeTest : MonoBehaviour
{
    //Creat Properties for the following
        //Sped (public get, private read only)
        //Name (public)

    public int Speed { get; private set; }
    //Does the same as above code using normal property
    /*
    private float _speed;
    public float Speed
    {
        get
        {
            return _speed;
        }
    }
    */

    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
            Debug.Log("Name is: " + _name);
        }
    }
    private void Start()
    {
        Name = "Nima";
        Speed = 2;
        Debug.Log("The speed is: " + Speed);
        //Testing testing = new Testing();
    }
}

/*
When to use properties:
Properties are used for good software design.
You don't want to give every object access to manipulate your variables.
Remember in programming everything needs to be private unless you need to give access to that value.
Using properties you have more control over which object gets to change your values.

Remember the down side of properties as well:
You have to initialize your properties in order to assign them
Does not show up in Unity inspector

Usually good for using in your manager classes for the variable you don't need to
see in the inspector like bool gameover, score.

 */
