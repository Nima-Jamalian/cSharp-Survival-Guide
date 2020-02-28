using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodArray : MonoBehaviour
{

    private GameObject[] _cubes;
    [SerializeField] private Vector3[] _positions;
    // Start is called before the first frame update
    void Start()
    {
        //GetAllCubes(); // This will also wrok
        _cubes = GetAllCubes();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private GameObject[] GetAllCubes()
    {
        GameObject[] allCubes = GameObject.FindGameObjectsWithTag("Player");
        foreach(var item in allCubes)
        {
            item.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            RandomPos(item);
        }
        return allCubes;
    }

    /*
    * Creat an array of 5 different postions and use a custom method to generate a random index
    * and then use a custom method to set the position to that sub index.
    */
    private void RandomPos(GameObject obj)
    {
        obj.transform.position = GetPosition(GetRandom());
    }

    private int GetRandom()
    {
        return Random.Range(0, _positions.Length);
    }

    Vector3 GetPosition(int index)
    {
        return _positions[index];
    }



}
