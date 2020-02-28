using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PracticeMain : MonoBehaviour
{
    //Create a delegate of type void that calculate the sum of two numbers.
    //Use a lambda to avoid having a dedicated method
    // Start is called before the first frame update
    private Action<int, int> Sum;

    void Start()
    {
        Sum = (input1, Input2) =>
        {
            var total = input1 + Input2;
            if(total < 100)
            {
                Debug.Log("Total is less than 100");
            }
            Debug.Log("Total: " + total);
        };
        Sum(5, 5);//invoking the lambda expression
        //Using dedicated method
        //Sum = CalculateSume;
        //Sum(5, 5);
    }
    //Usisng dedicated method
    //void CalculateSume(int a, int b)
    //{
    //    var total = a + b;
    //}
}
