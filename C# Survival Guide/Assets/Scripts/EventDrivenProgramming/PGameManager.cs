using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGameManager : MonoBehaviour
{
    private void OnEnable()
    {
        PPlayer.onDeath += ResetPLayer;//+= you can only add to event you can use = which mean assigning 
    }

    public void ResetPLayer()
    {
        Debug.Log("Resetting Player");
    }
}
