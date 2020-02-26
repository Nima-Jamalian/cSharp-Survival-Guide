using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtilityHelper : MonoBehaviour
{
    [SerializeField] private bool _randomColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ColorChangeUtilityHelper.ChangeColor(this.gameObject, Color.red, _randomColor);
        }
    }
}
