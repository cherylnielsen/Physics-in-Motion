using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


/***
 * Programs a digital timer for use in Lab and Lobby GUIs.
 * Displays seconds  while updating every frame.
 * Uses local time.
 * 
 * author:  Cheryl Nielsen
 * date:    Oct 17, 2022
 * version: 1.0
 * 
 */
public class DigitalTimer : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private long startTime;
    private double deltaTime;
    private bool isTimerOn;

    // Awake is called when script is first loaded,
    // or when the attached object is instantiated, 
    // even if the script is disabled.
    void Awake()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        isTimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerOn)
        {
            deltaTime = Convert.ToDouble((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) - startTime)/1000.00;
            timeText.text = "Timer (seconds): " + deltaTime.ToString("F3");
        }        
    }

}
