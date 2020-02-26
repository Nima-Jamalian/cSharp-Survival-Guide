using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] private Spell[] _spells;
    public int level = 1;
    public int exp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //iterate through the spell list and compare to my current level
            //cast spell
            foreach(var speel in _spells)
            {
                if(speel.levelRequired == level)
                {
                    speel.Cast();
                    exp += speel.expGained;
                }
            }

        }
    }
}
