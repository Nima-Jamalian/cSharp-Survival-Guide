using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodChallenge : MonoBehaviour
{
    /*
     * Creat a program that checks if the player is dead or not. When you hit the space key, you should damage
     * The player by random amount. If the player is daed (health less than 1), print out "The player has died!"
     *
     * Bounus: Prevent the damage function from beign called once player is dead and no negative health value
     */

    [SerializeField] private int _health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerDead() == false)
        {
            DamagePlayer(Random.Range(0, 100));
        }
    }

    private void DamagePlayer(int damageAmount)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _health -= damageAmount;
        }
        if(isPlayerDead() == true)
        {
            _health = 0;
            print("The player has died");
        }
    }

    private bool isPlayerDead()
    {
        return _health < 1;//setting a condition for return, if health < 1 -> isPlayerDead method will retutn true
    }


}
