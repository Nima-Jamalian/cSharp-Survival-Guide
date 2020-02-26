using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerR
{
    public string name;
    public int id;

    public PlayerR(int id)
    {
        this.id = id;
    }
}

public class PlayerC : MonoBehaviour
{
    public Dictionary<int, PlayerR> playersDiectionary = new Dictionary<int, PlayerR>();
    PlayerR p1,p2,p3;
    // Start is called before the first frame update
    void Start()
    {
        p1 = new PlayerR(1);
        p1.name = "Jimmy";
        playersDiectionary.Add(p1.id, p1);

        p2 = new PlayerR(200);
        p2.name = "Kyle";
        playersDiectionary.Add(p2.id, p2);

        p3 = new PlayerR(9);
        p3.name = "Yin";
        playersDiectionary.Add(p3.id, p3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playersDiectionary[p2.id];
            Debug.Log("Player name: " + player.name);
        }
    }
}
