using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public enum EnemeyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemeyState currecntState;

    // Start is called before the first frame update
    void Start()
    {
        //initilzing enum
        //the game start in patrolling mode
        currecntState = EnemeyState.Patroling;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currecntState)
        {
            case EnemeyState.Patroling:
                Debug.Log("Patrolling");
                if(Time.time > 5)
                {
                    //chaning the sate to chaing
                    currecntState = EnemeyState.Chasing;
                }
                break;
            case EnemeyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemeyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemeyState.Death:
                Debug.Log("Desth");
                break;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //chaning the sate to attacking
            currecntState = EnemeyState.Attacking;
        }
    }
}
