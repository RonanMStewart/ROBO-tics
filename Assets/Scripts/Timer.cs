using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
 public float TimeRemaining;
 public bool TimeOn = false;
 public Text TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(TimeOn)
        {
            if(TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
                updateTime(TimeRemaining);
            }
            else 
            {
                TimeRemaining = 0;
                TimeOn = false;
                TimerTxt.text = string.Format("Failure");
                TimerTxt.color = Color.red;
            }
        }
        
    }
    
    void updateTime(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}