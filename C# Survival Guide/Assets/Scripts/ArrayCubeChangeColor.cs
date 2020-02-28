using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCubeChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject[] _cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var item in _cubes)
            {
                item.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }
}
