using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Event (Specilized deligates):
Event or specialized delegates allows us to creat
e a broadcast system that allows other classes to
subscribe and unsubscribe to our delegates.

Events have inheritance security where delegates don’t.
If you use a delegate variable, other classes can invoke and
control the execution of your event. With event only it allows
other classes to subscribe and unsubscribe.
You can only invoke an event through the main event class.


//Usefull for self contined code meaning we don't need to use lots refrecnes.
We can issolate functionalities it allows for a notification system

For this example if we didn't use event and delegate our main method needed
to know about all thoese cube and then we need to loop through them all to turn them red
this way would be fine for small number but let's say you have 10,000 cubes in your since
using event and delegate you improve your coe significntly 
Example use:
You are creating an enemy AI system and when enemy health gets bellow 50% you want all of them to notify
souronding enemies we can use event system for
*/
public class Event : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    private void ButtonClick()
    {
        //turn all cubes red
        if(onClick != null)
        {
            //invoke
          onClick();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
