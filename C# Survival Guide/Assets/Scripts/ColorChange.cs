using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    /*
     * Creats a program that turns a cube to different colors based on user input
     * 1 key = blue
     * 2 key = red
     * 3 key = green
     * 4 key = blue
     */
    private MeshRenderer _meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _meshRenderer.material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _meshRenderer.material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _meshRenderer.material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _meshRenderer.material.color = Color.black;
        }
    }
}
