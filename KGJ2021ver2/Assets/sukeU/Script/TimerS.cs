using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerS : MonoBehaviour
{
    float time,displayTime;
    public float countDown;
    GameObject textObj,configObj;
    Text timerText;
    ConfigS ConfigS;
    
    // Start is called before the first frame update
    void Start()
    {
        time = countDown;
        textObj = transform.GetChild(0).gameObject;
        timerText = textObj.GetComponent<Text>();
        configObj = GameObject.Find("Config");
        ConfigS = configObj.GetComponent<ConfigS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ConfigS.handOver == false)
        {
            time -= Time.deltaTime;
        }
        displayTime = (int)time;
        timerText.text = displayTime.ToString();
    }
}
