using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizeCalculator : MonoBehaviour
{
    [SerializeField] private float[] _grades;
    private float _totoalGrade;
    [SerializeField] private float _avarage = 0;
    [SerializeField] private bool _CanGenerateRadnomMark;
    // Start is called before the first frame update
    void Start()
    {
        RrandomMarkGenerator();
        AverageCalculator();
        AverageGrader();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void AverageCalculator()
    {
        for (int i = 0; i < _grades.Length; i++)
        {
            _totoalGrade += _grades[i];
        }
        print("Total Grades Are: " + _totoalGrade);
        print("Number of Participants Are: " + _grades.Length);
        _avarage = _totoalGrade / _grades.Length;
        print("Class Avarage is: " + _avarage);
    }

    private void AverageGrader()
    {
        /*
         * Print A = > 90
         * Print B = >= 80 but less than 90
         * Print C = > 70 < 80
         * Print F less than 70
         */
         if(_avarage >= 90)
        {
            print("Average Grade: A");
        } else if (_avarage >= 80 && _avarage < 90)
        {
            print("Average Grade: B");
        } else if (_avarage >= 70 && _avarage < 80)
        {
            print("Average Grade: C");
        } else if (_avarage < 70)
        {
            print("Avarage Grade: F");
        }

    }

    private void RrandomMarkGenerator()
    {
        if (_CanGenerateRadnomMark)
        {
            _grades[0] = Random.Range(1, 101);
            _grades[1] = Random.Range(1, 101);
            _grades[2] = Random.Range(1, 101);
            _grades[3] = Random.Range(1, 101);
            _grades[4] = Random.Range(1, 101);

        }
    }
}
