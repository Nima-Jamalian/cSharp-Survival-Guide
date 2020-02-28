using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank 
{
    protected string branchName;
    protected string location;
    protected int cashInVault;

    protected void CheckBalance()
    {
        Debug.Log("CheckingBlance: " + branchName);
    }

    protected void Withdrawl()
    {
        Debug.Log("Withdrawling Money from: " + branchName);
    }

    protected void Deposite()
    {
        Debug.Log("Depositing money to: " + branchName);
    }
}
