using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour, IDamagable<float>, IShootable//Inheriting from more than one class, because we are using interfaces
{
    /*
    public int Health { get; set; }
    public void Damage(int damangeAmount){
    }
    */
    public int Health { get; set; }

    public void Damage(float damageAmount)
    {
        //Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
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
