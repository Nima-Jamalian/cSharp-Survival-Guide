using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Creat a program where you add "Customers" to a database. Assume you are creating some sowftware where you need
 * to store customer information.
 *
 * Looking at this problem, you need to think abouth what is a customer? What "defines" a customer?
 * We'll need a custom class that represents a customer and use it as a "blue print" for all customer.
 *
 * Creat at least 3 Customers visa code using a constructor and then transition it to being able to add
 * customers through the inspector.
 *
 * You'll need two classes. A CustomrDatabase (behaviour) which "holds" customer information and a customer class
 * which degined a customer.
 */ 
public class CustomerDatabase : MonoBehaviour
{
    [SerializeField] private Customer _nima;
    [SerializeField] private Customer _samira;
    [SerializeField] private Customer _mohammad;
    [SerializeField] private Customer[] _customers;
    // Start is called before the first frame update
    void Start()
    {
        _nima = new Customer("Nima", "Jamalian", 24, "Male", "Sowftware Enginner");
        _samira = new Customer("Samira", "Jamalian", 31, "Femail", "Sowftware Enginner");
        _mohammad = new Customer("Mohammad", "Jafarnejad", 31, "Mail", "Sowftware Enginner");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
