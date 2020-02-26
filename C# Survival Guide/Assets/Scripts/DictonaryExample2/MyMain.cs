using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMain : MonoBehaviour
{
    private Dictionary<string, int> people = new Dictionary<string, int>();
    private Dictionary<int, string> _books = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start()
    {
        people.Add("Jon", 26);
        people.Add("James", 55);
        people.Add("Nima", 24);
        people.Add("Yin", 34);

        int nimaAge = people["Nima"];
        Debug.Log("Nima age is: " + nimaAge);


        _books.Add(0, "Unity Guide");
        _books.Add(1, "SteamVR Guid");

        Debug.Log(_books[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
