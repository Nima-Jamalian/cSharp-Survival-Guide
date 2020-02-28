using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    [SerializeField] private int _apples;
    // Start is called before the first frame update
    void Start()
    {
        while(_apples < 50)
        {
            _apples++;
        }
    }
}
