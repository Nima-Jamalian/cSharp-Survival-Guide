using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Challenge: Creat a list/array of 3 gameobject to spawn and randomly spawn them with a random position on the screen
 * between -10 and +10 on the X/Y when you hit the space key. Every object you spawn should be stored into a list called
 * objectsCreated. Whe you have spawned 10 objects, you will no longer be able to spawn objects and will turn all
 * objects created GREEEN and then CLEAR the lsit and repet the process.
 */ 
public class ListChallenge2 : MonoBehaviour
{
    //using array cause we have specific number of objects 
    [SerializeField] private GameObject[] SpawnObjectsPrefabs = new GameObject[3];
    //using list because we want it to be dynamic, we want to be able to clear it.
    private new List<GameObject> objectsCreated = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press space to spawn object");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject randomObject = SpawnObjectsPrefabs[Random.Range(0, SpawnObjectsPrefabs.Length)];
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            if(objectsCreated.Count != 10)
            {
                GameObject createdObject = Instantiate(randomObject, randomPosition, Quaternion.identity);
                objectsCreated.Add(createdObject);
            }

            if(objectsCreated.Count == 10)
            {
                foreach(var spawnedObject in objectsCreated)
                {
                    spawnedObject.GetComponent<Renderer>().material.color = Color.green;
                }
                objectsCreated.Clear();
            }
            print(objectsCreated.Count);

        }
    }
}
