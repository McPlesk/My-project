using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool getTimerActive;
    public static float currentTime;
    public Text currentTimeText;
    public float getBestTime;
    public Text bestTimeText;
    public int getThisLevel;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        getThisLevel = endTime.sendThisLevel;
        getBestTime = endTime.bestTime[getThisLevel];
        TimeSpan time = TimeSpan.FromSeconds(getBestTime);

        bestTimeText.text = (getBestTime == 0) ? "" : "Best time: " + time.ToString(@"mm\:ss\:ff");

    }

    // Update is called once per frame
    void Update()
    {
        getTimerActive = endTime.timerActive;
        if (getTimerActive == true){
            currentTime = currentTime + Time.deltaTime;
        }

        if (currentTime <= getBestTime || getBestTime == 0){
            currentTimeText.color = Color.green;
        }
        else {
            currentTimeText.color = Color.red;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:ff");
    }
}