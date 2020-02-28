using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChallengeMain.onPress += MoveCube;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveCube()
    {
        transform.position = new Vector3(5, 2, 0);
    }
}
