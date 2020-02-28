using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumberChecker : MonoBehaviour
{
    [SerializeField] private int _startPoint = 0;
    private int _input;
    [SerializeField] private int _endPoint = 960;
    // Start is called before the first frame update
    void Start()
    {
        _input = _startPoint;
        for (_input = _startPoint; _input <= _endPoint; _input++)
        {
            bool foundPrimeNumber = IsPrimeByBruteForce(_input);
            if (foundPrimeNumber == true)
            {
                print(_input);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool IsPrimeByBruteForce(int number)
    {
        if (number < 2)
            return false;
        for (int i = 2; i < number; i++)
        {
            //A number "number" is divisible by another number "i"
            //if the rest of the division of number divided i equals to zero
            if (number % 2 == 0)
            {
                return false;
            }
            if (i % 2 != 0)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

        }
        //If no exist a number between 2 and number-1 that divides number
        return true;
    }
}
