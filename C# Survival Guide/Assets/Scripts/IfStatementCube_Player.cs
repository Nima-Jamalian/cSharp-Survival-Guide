using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementCube_Player : MonoBehaviour
{
    /*
     * Creat a program that when you hit the space key, you increment a score value.
     * When the score value is greater then 50. You turn the Cube green.
     * At the start of the program, set the cube to red.
     */
    [SerializeField] private GameObject _cube;
    [SerializeField] private int _score;
    private Material _cubeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        _cubeMaterial = _cube.GetComponent<MeshRenderer>().material;
        _cubeMaterial.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 25;
        }
        if(_score > 50)
        {
            _cubeMaterial.color = Color.green;
        }
    }
}
