using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Stacking method 
        Event.onClick += TurnRed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    //good practice to to always unsubscribe from event after you are finished with them
    //inorder avoid creating any type of error in your application
    private void OnDisable()
    {
        Event.onClick -= TurnRed;
    }
}
