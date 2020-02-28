using System;//access the code library for action
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayer : MonoBehaviour
{
    //Actions are same as event and delegate the only difference
    //instead of needing two line one declaring delegate
    //and the then declaring event using action you can creat
    //delegate and event in one line.
    //action are type safe meaning they behave like event
    //so there is no need to declare action as event
    //Action interduced 3.5 version of CLR(Common Language Runtime)
    //Event and delegate were interduced at 2.0 version
    public Action onReady;// = public delegate void onReady();

    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamageReceived;

    public static Action<int> onDamageReceived;//<int> mean the method take an int as input

    public int Health { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        if(onDamageReceived != null)
        {
            onDamageReceived(Health);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
