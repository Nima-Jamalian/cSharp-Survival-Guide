using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityHelperClassPlayer : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Utilityhelper.CreatObject();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Utilityhelper.SetPositionToZero(this.gameObject);
        }
    }
}
