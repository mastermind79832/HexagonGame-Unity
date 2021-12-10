using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{

    public static bool isGameStart= false;

    public static bool isGameOver = false;


    // Start is called before the first frame update
    void Awake()
    {
        isGameStart = false;
        isGameOver = false;
    }

    public static void GameOver()
    {
        isGameOver = true;
        GameObject[] hexagons = GameObject.FindGameObjectsWithTag("Hexagon");
        foreach(GameObject hexagon in hexagons)
            GameObject.Destroy(hexagon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
