using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopChallenge2 : MonoBehaviour
{
    /*
     * Creat a program where you increment the value of speed by 1 every second -- when the speed is greater
     * then MaxSpeed, stop incrementing
     * MaxSpeed = (Random between 60 and 120)
     * Note: You don't know value of MaxSpeed(imaginary variable)
     * Hints:
     * Use Coroutine
     */
    [SerializeField] private int _speed;
    [SerializeField] private int _MaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _MaxSpeed = Random.Range(60, 120);
        StartCoroutine(IncrementSpeed());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator IncrementSpeed()
    {
        /*
        //While Loop Implementation
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            _speed += 5;
            if (_speed > _MaxSpeed)
            {
                break;
            }

        }
        */

        //Do While Loop Implementation
        do
        {
            yield return new WaitForSeconds(1.0f);
            _speed += 5;
        } while (_speed > _MaxSpeed);
    }
}
