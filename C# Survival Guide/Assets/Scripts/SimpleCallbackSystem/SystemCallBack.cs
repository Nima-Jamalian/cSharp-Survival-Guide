using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SystemCallBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyRoutine(() => { Debug.Log("The Routine has finished"); })); //using lambda expersion inise Ienumerator input
    }
    private IEnumerator MyRoutine(Action onComplete = null)//optional input set to null so you can use it without input
    {
        yield return new WaitForSeconds(3.0f);
        //Debug.Log("The Routine has finished");
        if (onComplete != null)
        {
            onComplete();
        }
    }
}
