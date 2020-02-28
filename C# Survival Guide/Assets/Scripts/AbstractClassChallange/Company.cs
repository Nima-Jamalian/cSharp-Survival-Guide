using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Challenge:

    Crea an abstract Employee Class that defined the following traits:
    - Company Name
    - Employee Name
    - CalculateMonthlySalary();

    ---------------
    FullTime : Employee
    - Salary

    //Force impliment CalculateMonthlySalary();

    Parttime : Employee
    - hourseWorked
    - hourlyRate

    //Force impliment CalculateMonthlySalary();
    */
public abstract class Employee1 : MonoBehaviour
{
    public string company;
    public string name;
    public abstract void CalculateMonthlySalary();
}
public class FullTime : Employee1
{
    public float salary;
    public override void CalculateMonthlySalary()
    {
        //throw new System.NotImplementedException();
        print( name + " salary is " + salary);
    }
}
public class PartTime : Employee1
{
    public float hourseWorked;
    public float hourlyRate;
    public override void CalculateMonthlySalary()
    {

        //throw new System.NotImplementedException();
        print(name + " salary is " + (hourseWorked * hourlyRate));
    }
}

public class Company : MonoBehaviour
{
    FullTime andrea = new FullTime();
    PartTime nima = new PartTime();
    // Start is called before the first frame update
    void Start()
    {
        andrea.name = "Andrea";
        andrea.company = "Goldsmiths";
        andrea.salary = 500;
        andrea.CalculateMonthlySalary();

        nima.name = "Nima";
        nima.company = "Goldsmiths";
        nima.hourseWorked = 20;
        nima.hourlyRate = 21;
        nima.CalculateMonthlySalary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
