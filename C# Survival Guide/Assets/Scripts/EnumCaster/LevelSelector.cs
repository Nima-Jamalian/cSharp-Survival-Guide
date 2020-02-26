using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelSelector : MonoBehaviour
{
    private enum Difficulty
    {
        Easy,//0
        Normal,//1
        Hard,//2
        Expert//3
    }
    [SerializeField] private Difficulty selectedDifficulty;
    // Start is called before the first frame update
    void Start()
    {
        print((int)selectedDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
