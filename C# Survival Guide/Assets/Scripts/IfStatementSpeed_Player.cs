using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementSpeed_Player : MonoBehaviour
{
    /*
     * Creat a program that let's you increment the speed when you hit the S key
     * A key decrements the speed.
     * When the speed is greater then 20 you need to print out "Slow Down"
     * When the speed is 0 print out you need to speed up!
     * You can't go below zero.
     */

    [SerializeField] private int _speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed += 5;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _speed -= 5;
        }
        if (_speed > 20)
        {
            print("Slow Down");
        }
        else if (_speed == 0)
        {
            print("You need to speed up.");
        }
        if(_speed < 0)
        {
            _speed = 0;
        }
    }
}
