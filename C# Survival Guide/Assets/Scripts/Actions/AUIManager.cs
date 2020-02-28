using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUIManager : MonoBehaviour
{
    public void OnEnable()
    {
        APlayer.onDamageReceived += UpdateHealth;
    }
    public void UpdateHealth(int health)
    {
        //display update health here
        Debug.Log("Current Health: " + health);
    }
}
