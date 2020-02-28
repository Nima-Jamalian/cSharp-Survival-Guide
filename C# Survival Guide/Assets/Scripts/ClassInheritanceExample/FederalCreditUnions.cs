using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FederalCreditUnions : Bank
{
    public int availableCashToLend;

    public void ApprovedLending()
    {
        Debug.Log("You are awarded a loan!");
    }
}
