using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MyScript2 : MonoBehaviour
{
    //Create a delegate of type int that takes 2 numbers as a parameter and adss the sum
    private Func<int, int, int> CalculateSum;
    [SerializeField] private int _num1;
    [SerializeField] private int _num2;
    [SerializeField] private int _result;
    // Start is called before the first frame update
    void Start()
    {
        CalculateSum = (_num1, _num2) => _num1 + _num2;
        _result = CalculateSum(_num1, _num2);//Invoking CalculateSum
        Debug.Log(_num1 + " + " + _num2 + " = " + _result);
    }
}
