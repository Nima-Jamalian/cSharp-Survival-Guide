using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    //Constructor
    //Can set how we initilize the calss object using Constructor
    //Constructor always need to be set as public -> Bcause we want to acsses it from another class and use it to initilize the calss object
    //Constructor Name should be same as the class
    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        //Initialize thing here
        //this. beacuse the local variable names and vriable name at the top is the same
        //this. represent the variables at the top
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class Class : MonoBehaviour
{

    private WeaponStats blasters;
    private WeaponStats rockets;
    // Start is called before the first frame update
    void Start()
    {
        //using constuctor to initialize calss object
        blasters = new WeaponStats("Blasters", 0.25f, 50);
        rockets = new WeaponStats("Rockets", 5f, 1);

        print(blasters.name);
        print(blasters.fireRate);
        print(blasters.ammoCount);

        /*
         * If we do not use constructor this is how we intilize class object
         * and after we assign each vraible one by one
         * This is bad practice, time consuming and not clean
         */
        /*
        blasters = new WeaponStats();
        blasters.name = "Blasters";
        blasters.fireRate = 0.25f;
        blasters.ammoCount = 50;

        rockets = new WeaponStats();
        rockets.name = "Roket";
        rockets.fireRate = 5.0f;
        rockets.ammoCount = 1;
        */
    }
}



