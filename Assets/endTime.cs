using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class endTime : MonoBehaviour
{
    public static bool timerActive;
    public GameObject Other;
    public int thisLevel;
    public static int sendThisLevel;
    public static float attemptTime;
    public static float[] bestTime = {0,0,0,0,0};
    
    // Start is called before the first frame update
    void Start()
    {
        timerActive = true;
        sendThisLevel = thisLevel;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "player"){
            timerActive = false;
            Destroy(Other);
            
            attemptTime = Timer.currentTime;

            if (bestTime[thisLevel] == 0 || attemptTime < bestTime[thisLevel]){
                bestTime[thisLevel] = attemptTime;
            }
        }
    }
}