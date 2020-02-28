using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Event.onClick += ActivateGravity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActivateGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
