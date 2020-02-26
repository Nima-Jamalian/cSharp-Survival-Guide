using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Lists:
 * Similiar to arrya, list is a form or data tyoe that accespt multiple type
 * The only diffrenrce is we can extend a list at run time meaning we can populate it
 * we can increas the sie or decrease the size at run time or as in array it's fixed size
 *
 * So we we would use array in sitioiation were we don't need to change the size
 * For example: A game inventory system whihc has 20 slot and does not change
 *
 * List:
 * Example: Item data base were you controly going to add item you want to use list
 */
public class Lists : MonoBehaviour
{
    //Array
    public GameObject[] objectToSpawn = new GameObject[10];

    //List
    //<> is called T bracket
    public List<GameObject> enemiesToSpawn = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //seting
        //array
        objectToSpawn[0] = new GameObject();
        //list
        enemiesToSpawn.Add(new GameObject());
        //accessing
        //arrat
        objectToSpawn[2].name = "Nima";
        enemiesToSpawn[2].name = "Samira";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
