/*
 * Namespaces:
 * Namespace signifies we are going to use a code libraries.
 * Code libraries are a collection of different classes.
 * Namespaces give you ability to share your code without interfering with other code in the project
 * Example: Scripts having same name would cause problem but using namespaces we can avoid this problem from happening.
 */
using System.Collections;//access c# libraries
using System.Collections.Generic;
using UnityEngine;//allows us to inherit from MonoBehavoiur -> which allows us apply scripts to gameobjects
using UnityEngine.UI;//allows us to use interact with UI
using UnityEngine.SceneManagement;//allows us to access to scene management
using WeaponPack;
using WeaponPack.Magic;

public class NamespacesTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Image
        //SceneManager.LoadScene
        WeaponPack.NamespacesTest sword = new WeaponPack.NamespacesTest(); 
        WeaponPack.Magic.NamespacesTest1 magicSword = new WeaponPack.Magic.NamespacesTest1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
