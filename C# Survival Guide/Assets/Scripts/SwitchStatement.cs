using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    [SerializeField] private int _WeaponID;

    /*
     * ID 1 = Gun
     * ID 2 = Knife
     * ID 3 = Machine Gun
     */

    private void Update()
    {
        switch (_WeaponID)
        {
            case 1:
                print("You have a Gun.");
                break;
            case 2:
                print("You have a Knife.");
                break;
            case 3:
                print("You have a Machine Gun.");
                break;
            default:
                print("Invalid Weapon.");
                break;
        }
    }
}
