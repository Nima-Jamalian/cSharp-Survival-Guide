using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    /*
     * Creat a program where you assign a cube in the inspector and when you hit the space key
     * You pass the object into a function called ChangeColor. The function should take both
     * the Gameobject and a color to change to and the operation should be handled within the function.
     */
    [SerializeField] private GameObject _myCube;
    [SerializeField] private GameObject _mySphere;
    // Start is called before the first frame update
    void Start()
    {
        print("Press Space key to change Color.");
        print("Press S key to sum 2 + 3");
        print("Press D key to calculate 2 - 3");
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor(_myCube, Color.red);
        Sum(2, 3);

        if (Input.GetKeyDown(KeyCode.D))
        {
            print(Difference(2, 3));
        }

        ChangePosition(_myCube,Vector3.zero);

        _mySphere.transform.position = GetPosition(2, 2, 0);
    }

    private void ChangeColor(GameObject obj, Color colorToAssign)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
        }
    }

    private void Sum(int a, int b)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            print(a + b);
        }
    }

    private int Difference(int a,int b)
    {
        return a - b;
    }

    private void ChangePosition(GameObject obj, Vector3 pos)
    {
        obj.transform.position = pos;
    }

    private Vector3 GetPosition(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x, y, x);
        return pos;
    }
}
