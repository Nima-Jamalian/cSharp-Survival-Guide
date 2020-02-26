using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;//So Unity knows which Random method we are referring to
/*
* You are constantly changing the color of game objects within your game.
* Create a helper class that would let you turn any objects you pass into it, a color of your choice.
*
* To test:Creat a player behavior where you can hit the space key and call that method.
*
* Bonus: Randomize the color
*/
public static class ColorChangeUtilityHelper
{
    public static void ChangeColor(GameObject obj, Color color, bool randomColor = false)
    {
        //if randomColor == true
        //assign random color
        //obj material color = color
        if(randomColor == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
        obj.GetComponent<Renderer>().material.color = color;
    }
}
