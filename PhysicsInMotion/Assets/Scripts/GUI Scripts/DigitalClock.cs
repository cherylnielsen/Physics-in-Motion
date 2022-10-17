using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


/***
 * Class for active digital clock for use in Lab and Lobby GUIs.
 * Displays date and time for students and updates time every frame.
 * Uses local time.
 * 
 * author:  Cheryl Nielsen
 * date:    Oct 16, 2022
 * version: 1.0
 * 
 */
public class DigitalClock : MonoBehaviour
{
    private TextMeshProUGUI timeText;

    // Awake is called when script is first loaded,
    // or attached object is instantiated, 
    // even if the script is disabled.
    void Awake()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        timeText.text = time.ToString();
    }
}
