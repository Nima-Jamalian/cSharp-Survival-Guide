using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTypeExampleEnemy : MonoBehaviour
{
    private StaticTypeExampleUIManager _uI;
    //called automatically when the object gets enabled
    public void OnEnable()
    {
        StaticTypeExampleSpawnManager.enemyCount++;
        _uI = GameObject.Find("UIManager").GetComponent<StaticTypeExampleUIManager>();
        _uI.UpdateEnemyCount();
        Die();
    }

    //called automatically when the object gets disable
    public void OnDisable()
    {
        StaticTypeExampleSpawnManager.enemyCount--;
        _uI.UpdateEnemyCount();
    }

    private void Die()
    {
        Destroy(this.gameObject,Random.Range(2,6));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
