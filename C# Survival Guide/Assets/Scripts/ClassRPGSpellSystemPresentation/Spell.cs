using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    public Spell(string name, int levelRequired, int itemIdRequired, int expGained)
    {
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIdRequired = itemIdRequired;
        this.expGained = expGained;
    }

    public void Cast()
    {
        Debug.Log("Casting: " + this.name);
    }

}
