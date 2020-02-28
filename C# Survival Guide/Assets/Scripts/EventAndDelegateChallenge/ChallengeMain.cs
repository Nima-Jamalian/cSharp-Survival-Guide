using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Challenge: Create a program using delegates and events where you hit the space key and assign
a cube position of (5,2,0) 
The cube script should subscribe to the event and be invoked when you hit the key.
*/
public class ChallengeMain : MonoBehaviour
{
    public delegate void OnPress();
    public static event OnPress onPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onPress();
        }
    }
}
