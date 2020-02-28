using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Abstract classes force implementation. If you inherit from a class which is not abstract,
 * you can choose where you use method from that class or not. However If you inherit from an abstract
 * class which has an abstract method you must use that method otherwise your code would throw an error.
 * 
 * Abstract classes can not be initialized meaning we can not attach them to gameobject
 */

public abstract class Enemy1 : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;
    /*
    //This would give error beacuse we are declaring it as body
    //abstract methods can not have a body
    public abstract void Attack()
    {

    }
    */
    public abstract void Attack();

    public  virtual void Die()
    {
        Destroy(this.gameObject);
    }
}

public class GiantWolf : Enemy1
{
    private void Start()
    {
        //Attack();
    }

    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void Die()
    {
        //I can also add custom futures

        //base imelementation
        base.Die();
    }
}
