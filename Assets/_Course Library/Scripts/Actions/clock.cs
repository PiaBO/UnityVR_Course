using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour
{
    public Transform secondsHand;
    public Transform minutesHand;
    public Transform hourHand;

   
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        float second = (float) currentTime.Second;
        float minute = (float) currentTime.Minute;
        float hour = (float) currentTime.Hour%12;

        float secondAngle = 360 * (second/60);
        float minuteAngle = 360 * (minute/60);
        float hourAngle = 360 * (hour/12);

        secondsHand.localRotation = Quaternion.Euler(secondAngle,0,0);
        minutesHand.localRotation = Quaternion.Euler(minuteAngle,0,0);
        hourHand.localRotation = Quaternion.Euler(hourAngle,0,0);

    }

}
