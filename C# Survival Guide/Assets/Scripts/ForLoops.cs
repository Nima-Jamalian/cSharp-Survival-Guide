using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    /*
     * Creats a program where we increment the value of how many apples we have every secounds 
     */

    [SerializeField] private int _apples;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddAppleRoutine());
    }

    IEnumerator AddAppleRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            _apples++;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
