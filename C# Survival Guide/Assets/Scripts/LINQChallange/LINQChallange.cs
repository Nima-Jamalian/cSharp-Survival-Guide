using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINQChallange : MonoBehaviour
{
    /*
    Create a program where you have a integer array of quizzze grades.
    the quize grades should be between 0-100.
    filter through the quiz grades and create a new collection of only passing grades. above a 69.
     */

    [SerializeField] private int[] _marks = { 63, 54, 34, 89, 85, 99, 0, 45, 68, 69, 70 };
    // Start is called before the first frame update
    void Start()
    {
        //.Where(input => condition)
        //.OrderByDescending (input => comparison input)
        //Reverse() -> reverse your elment order in the list
        var _passingMarks = _marks.Where((_marks) => _marks > 69).OrderByDescending(_marks => _marks).Reverse();
        foreach(var mark in _passingMarks)
        {
            print(mark);
        }
    }
}
