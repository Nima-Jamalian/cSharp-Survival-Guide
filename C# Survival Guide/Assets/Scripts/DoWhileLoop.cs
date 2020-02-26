using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    [SerializeField] private int i;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            //statement code
            print(i);
            //index incrementer
            if(i<= 50)
            {
                i++;
            }
        } while (i < 50);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
