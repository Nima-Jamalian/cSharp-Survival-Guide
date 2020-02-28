using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string first, last;
    public int salary;

    public static string company;

    //Instance constructor get called after static constroctor
    public Employee()
    {
        Debug.Log("Instance Members Initialized");
    }

    //Static constructor gets called first
    //Static constructor can only get static data
    //Because it's static and gets shared across all instances.
    //Get called only one time since it's staic and does not change 
    static Employee()
    {
        company = "GameDevHQ";
        Debug.Log("Initialize Static Members");
    }

}

public class StaticConstructorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Employee e1 = new Employee();
        //var automatically detects your variable type
        //Which is Employee in this example
        //so var e2 is similar to saying Employee e2
        var e2 = new Employee();
        var e3 = new Employee();
        var e4 = new Employee();
        Employee e5 = new Employee();
        print(Employee.company);
    }
}
