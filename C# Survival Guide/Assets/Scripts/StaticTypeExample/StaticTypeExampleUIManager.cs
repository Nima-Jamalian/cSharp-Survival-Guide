using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticTypeExampleUIManager : MonoBehaviour
{
    //This is bad design example having text as and method as static memebers,
    //because we need to declare the text as static as well because static method can not
    //access instance memebers, they can only access static members so we need to declare text
    //as static as well, this is an example to show when to use static and when not to use it
    //For us it was very convenient to declare enemyCount as static because we can access to it directly
    //through the class, but it was not convenient to declare enemyTextUpdate as satic bacause we also needed to
    //set the text as static meaning we can no longer assign the text variable thorugh inspector
    //[SerializeField] private static Text _activeEnemiesText;

    //Static method are not able to communicate with non-static variables
    /*
    public static void UpdateEnemyCount()
    {
        _activeEnemiesText.text = "Active Enemies: " + StaticTypeExampleSpawnManager.enemyCount;
    }
    */

    [SerializeField] private Text _activeEnemiesText;
    //Static method are not able to communicate with non-static variables
    public void UpdateEnemyCount()
    {
        _activeEnemiesText.text = "Active Enemies: " + StaticTypeExampleSpawnManager.enemyCount;
    }
}
