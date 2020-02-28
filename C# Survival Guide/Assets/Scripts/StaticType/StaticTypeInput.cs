using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTypeInput : MonoBehaviour
{
    //private Score _score;
    // Start is called before the first frame update
    void Start()
    {
       // _score = GameObject.Find("Score Keeper").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //add 10 to score
            //_score.score += 10;

            //accessing score static variable through class level
            //direct access to the data no need to creat handle for the class
            Score.score += 10;

            Debug.Log("Current Score: " + Score.score);
        }
        
    }
}
