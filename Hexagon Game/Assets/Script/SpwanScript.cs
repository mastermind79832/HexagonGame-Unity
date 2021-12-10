using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanScript : MonoBehaviour
{

    public bool isGameStart= false;
    public float spwanSpeed = 1f;

    public GameObject hexagonPrefab;

    private float nextSpwan = 0f;

   
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextSpwan && GameController.isGameStart && !GameController.isGameOver)
        {
            
            GameObject hexa = Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);

            nextSpwan = Time.time + 1 / spwanSpeed;
           
        }
    }
 }

