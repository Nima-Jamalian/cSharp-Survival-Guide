using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//creating our own namespace
namespace WeaponPack {
    public class NamespacesTest : MonoBehaviour
    {
        //code for general weapon goes here
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
//We can also use . to creat more specific namesapce
//Example: this is only handel magic weapon
namespace WeaponPack.Magic
{
    public class NamespacesTest1: MonoBehaviour
    {
        //Code for magic weapon goes here
    }
}

