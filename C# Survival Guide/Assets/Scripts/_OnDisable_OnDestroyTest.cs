using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _OnDisable_OnDestroyTest : MonoBehaviour
{
    private void OnEnable()
    {
        print("Object is active");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Object will be deleted in 3 seconds");
        Destroy(this.gameObject, 3f);//activate both OnDisable and OnDestroy
        //gameObject.SetActive(false);//activate only OnDisable
    }


    private void OnDestroy()
    {
        print("Object has been destroyed.");
    }

    private void OnDisable()
    {
        print("Object has been disabled.");
    }

    // Update is called once per frame
    void Update()
    {

    }


}
