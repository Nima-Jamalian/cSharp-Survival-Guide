using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    /*
     Delegates:
     You can think of delegates as vraivable that hold a method or sevral methods.
     Remember that delegate is just a variable that hold method.
     */
    private delegate void ChangeColor(Color color);//you need to defind the type of method void/etc and also input
    private ChangeColor onChangeColor;

    private delegate void OnComplete();
    private OnComplete onComplete;
    // Start is called before the first frame update
    void Start()
    {
        onChangeColor = UpdateColor;//Setting the delagate to method, the method you set to delagate needs
        //to have exact same type and input sa delagate it self
        //for example we can not do 
        //onChangeColor = Task2;//this will throw an error the type is the same both are void but
        //task2 does not have any input but onChangeColor Delagate needs method that is void and take color as input
        onChangeColor(Color.green);//inovking the delagate

        //onComplete = Task;
        //Statcking methods on onComplete delegate
        //you use += sign when you have multiple method 
        onComplete += Task;
        onComplete += Task1;
        onComplete += Task2;
        //you can also remove task from delegate
        onComplete -= Task1;
        //Best practice is before invoking delegate
        //check if it's not null
        if(onComplete != null)
        {
            //Invoking method
            onComplete();
        }
    }
    private void UpdateColor(Color color)
    {
        Debug.Log("Changin color to: " + color.ToString());
    }

    private void Task()
    {
        Debug.Log("Task Finished.");
    }

    private void Task1()
    {
        Debug.Log("Task1 Finished.");
    }

    private void Task2()
    {
        Debug.Log("Task2 Finished.");
    }
}
