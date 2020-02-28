using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                //No need to implement method Damage activation liek bellow
                //Calling each Damage method one by one, time consuming for large programme
                /*
                if(hit.collider.name == "Player")
                {
                 hit.collider.GetComponent<Player3>().Damage(100);
                }
                if(hit.collider.name == "Enemy")
                {
                 hit.collider.GetComponent<Enemy3>().Damage(50);
                }*/
                //Since we are using interface we can call the damage method directly from interface
                //Then the interface automatically activates the Damage method for the object we hit
                //if the method has multiple input we need access the but input inorder to run the code
                IDamagable<int> obj = hit.collider.GetComponent<IDamagable<int>>();
                IDamagable<float> obj1 = hit.collider.GetComponent<IDamagable<float>>();
                //Also null check so the programme does not try to activate Damage method
                //when you have not hit anything
                if (obj != null)
                {
                    obj.Damage(100);
                }
                if (obj1 != null)
                {
                    obj1.Damage(2.3f);
                }
            }
        }
    }
}
