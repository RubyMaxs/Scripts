using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public string neinSec;
    public Timer timer;
    public TextMeshProUGUI timerMinSecText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.sec < 10)
        {
            neinSec = "0" + ((int)timer.sec).ToString();
            timerMinSecText.text = timer.min.ToString() + ":" + neinSec;
        }
        else
        {
            timerMinSecText.text = timer.min.ToString() + ":" + ((int)timer.sec).ToString();
        }

    }
}
