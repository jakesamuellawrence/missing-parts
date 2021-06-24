using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {

    public MusicTimer timer;

    private TextMeshProUGUI text;

    private void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        int seconds = (int)timer.GetTimeLeft();
        int minutes = 0;
        while (seconds >= 60) {
            minutes++;
            seconds -= 60;
        }
        string secondsString = seconds.ToString();
        if (seconds < 10) {
            secondsString = "0" + secondsString;
        }
        text.text = minutes + ":" + secondsString;
    }

}
