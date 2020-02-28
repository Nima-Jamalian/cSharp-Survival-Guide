using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Interfaces:
Interfaces are similar to abstract classes in the sense that they can force implementation.
While an abstract class can be thought of as a partial template.
Interfaces are contracts and whatever it is in that contract must be followed interfaces
don't allow for any implementation and can not contain fields.
Interfaces only allow for methods and properties.
Interfaces allows for a very important subject in programming
called polymorphism where an object shares relecency.

You can not inherit from other classes using interface
You can have public or private everything is assumed public
Allows for multiple class inheritance using interfaces using have as many as interfaces you want 
Naming interfaces -> you start with capital I and finish with the word able this shows the script is interface
*/

/*
 * Generic Interfaces: <T>
 */
public interface IDamagable<T>
{
    //Interfaces can not have fildes now you can not declare variables
    //int health; 
    //Properties are allowed in interfaces
    int Health { get; set;}
    //can have implementation detail in interfaces it's just a contract

    //You can have method with same name but different in take
    //void Damage(int damageAmount);
    //void Damage(float damageAmount);

    //using generic interfaces
    //instead of having two method with the same name but different input
    //we can have a generic method and can take different type of inputs
    //this way when classes inherit from this interface no longer need
    //implement diffrerent type of methods with same name but diffrerent input
    //they only implement the generic method and then they set the type they want as the input
    void Damage(T damageAmount);
}
