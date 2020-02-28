using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PUIManager : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;

    private void OnEnable()
    {
        PPlayer.onDeath += UpdateDeathCount;
    }
    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
