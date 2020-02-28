using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour, IDamagable<int>
{
    //You need have these since they are part of interface
    //other wise you would get an error saying you are not implementing the interface memebers
    
    public int Health { get; set; }

    public void Damage(int damangeAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
