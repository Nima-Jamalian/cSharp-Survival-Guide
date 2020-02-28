using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsPlayer : MonoBehaviour
{
    private int _myAge = 24;
    private int _legalAgeToDrive = 18;

    int _points;
    bool _hasSiadMessage;

    [SerializeField] private int _easyDifficulty = 0;
    [SerializeField] private int _mediumDifficulty = 1;
    [SerializeField] private int _hardtDifficulty = 2;
    [SerializeField] private int _currentDifficulty;

    // Start is called before the first frame update
    void Start()
    {
       if(_myAge >= _legalAgeToDrive)
        {
            print("You can drive.");
        } else
        {
            print("You are not old enough to drive.");
        }
        _currentDifficulty = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //everytime we hit the space key
        //add 10 point
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }
        print(_points);

        if(_points >= 50 && !_hasSiadMessage)
        {
            print("You are awsome!");
            _hasSiadMessage = true;
        }


        if(_currentDifficulty == _easyDifficulty)
        {
            print("You selected easy");
        } else if (_currentDifficulty == _mediumDifficulty)
        {
            print("You selected medium");
        } else if (_currentDifficulty == _hardtDifficulty)
        {
            print("You selected hard");
        } else
        {
            print("Invalid level selected");
        }
    }

}






