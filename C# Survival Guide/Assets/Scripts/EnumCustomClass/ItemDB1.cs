using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB1 : MonoBehaviour
{
    public List<item1>  itemDB1 = new List<item1>();

    // Start is called before the first frame update
    void Start()
    {
        itemDB1[0].Action();
        itemDB1[1].Action();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
