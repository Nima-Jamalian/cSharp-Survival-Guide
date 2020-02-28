using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    /*
    [SerializeField] string name1 = "Nima";
    [SerializeField] string name2 = "Ali";
    [SerializeField] string name3 = "Hossein";
     //[SerializeField] private string[] _names;
    */
    /*
     * Creat an array of 5 names and print out the last person names
     * Creat an array of 5 ages that corospond the each person and print out the last age
     * Creat an araay of 5 Car Models and associate them with each person and print out the last person favorite car
     *
     * Bonus:
     * Handle the print out when the space key is pressed.
     * Select information about one of the person randomly and print out all information about that person.
     * Print all name if the N keu is pressed. IF any person has the name Nima prting -> Nima is in the list.
     *
     *
     * Print all the ages using foreach loop. when A key is pressed
     * if car name GTR is in the there, print "GTR is here"
     * 
    */
    //Used most often
    //declare the size (how many elements through the inspector)
    [SerializeField] private string[] _names;

    //declare the size though inspector
    [SerializeField] private string[] _cars = new string[5];

    //Setting the elements when array is created though script
    //safe value saved though code
    [SerializeField] int[] _ages = new int[] { 5, 3, 2, 55, 66 };
    // Start is called before the first frame update
    void Start()
    {
        print("Press Space Key to slecet the last person.");
        print("Press R key to select a random person.");
        print("Prees N to print out all Names.");
        print("Press A to print all the cars");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Nmae: " + _names[4] + " Age: " + _ages[4] + " Favorite Car: " + _cars[4]);
        }

        if (Input.GetKeyDown(KeyCode.R)){
            int RandomID = Random.Range(0, 5);
            print("Random Person Slected is Number: " + RandomID);
            print("Name: " + _names[RandomID] + " Age: " + _ages[RandomID] + " Favorite Car: " + _cars[RandomID]);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i] == "")
                {
                    print(i + "is the null element.");
                } 
                Debug.Log(_names[i]);
                if(_names[i] == "Nima")
                {
                    print("Nima is in the list");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //for each loops only works on collections(arrays and lists)
            foreach(var item in _cars)
            {
                print(item);
                if(item == "GTR")
                {
                    print("GTR IS HERE!");
                }
            }
        }
    }
}
