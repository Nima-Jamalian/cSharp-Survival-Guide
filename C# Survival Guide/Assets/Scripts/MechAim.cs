using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechAim : MonoBehaviour
{
    [SerializeField] private Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - source
        Vector3 _directionToFace = _player.position - transform.position;
        Debug.DrawRay(transform.position, _directionToFace, Color.green);
        Quaternion targetRotation = Quaternion.LookRotation(_directionToFace);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}
