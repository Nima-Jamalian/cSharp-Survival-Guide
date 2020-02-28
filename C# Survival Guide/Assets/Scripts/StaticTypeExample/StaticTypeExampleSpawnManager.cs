using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTypeExampleSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    //When to use static types:
    //When you have data that is shared across your entire game and there is
    //only one of them and every class is sharing that data you can use static
    public static int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_enemyPrefab);
        }
        
    }
}
