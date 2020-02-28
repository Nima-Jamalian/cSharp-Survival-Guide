using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePrinter : MonoBehaviour
{
    //Challenege: Creat a list of names and print out each one.
    //When you hit the space key, "Remove" a random element from the list and reprint the names
    //Also specify which name has been deleted 
    [SerializeField] private List<string> names = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        names.Add("Nima");
        names.Add("Noushin");
        names.Add("Mohammad");
        names.Add("Samira");
        names.Add("Andrea");
        PrintNames();
        Debug.Log("Press Space Key to remove a random name and re print the list");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && names.Count != 0)
        {
            Debug.Log("--------------------------------------------");
            var nameToRemove = names[Random.Range(0, names.Count)];
            names.Remove(nameToRemove);
            PrintNames();
            print(nameToRemove + " Has been deleted");
            Debug.Log("Press Space Key to remove a random name and re print the list");
        } if (Input.GetKeyDown(KeyCode.Space) && names.Count == 0)
        {
            Debug.Log("--------------------------------------------");
            Debug.Log("List is empty!");
        }
    }

    private void PrintNames()
    {
      foreach(var element in names)
        {
            print(element);
        }
    }
}
