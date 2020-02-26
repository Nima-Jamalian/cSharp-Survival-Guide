using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    [SerializeField] private float _bill;
    [SerializeField] private float _TipPercentage = 20.0f;
    private float _tipAmount;
    private float _totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        _tipAmount = _TipPercentage * (_bill / 100);
        _totalAmount = _bill + _tipAmount;
        print("Your bill is: £" + _bill + " and your tip amount is: £" + _tipAmount + " so you own: £" + _totalAmount + " in total.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
