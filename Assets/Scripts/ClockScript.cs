using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockScript : MonoBehaviour
{
    [SerializeField] TMP_Text time;
    int seconds;
    int minutes;

    string timeString = "00:00";

    // Start is called before the first frame update
    void Start()
    {
        time.text = timeString;
        InvokeRepeating("ChangeTime", 1.0f, 1.0f);
    }

    void ChangeTime()
    {
        seconds += 1;
        if (seconds == 60)
        {
            minutes += 1;
            seconds = 0;
        }
        time.text = ConvertToString(minutes) + ":" + ConvertToString(seconds);
    }

    string ConvertToString(int num)
    {
        string str = num.ToString();
        if (num < 10)
        {
            str = "0" + str;
        }
        return str;
    }
    
}
