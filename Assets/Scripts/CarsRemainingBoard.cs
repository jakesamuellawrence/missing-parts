using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarsRemainingBoard : MonoBehaviour {

    public string prefix;
    public string suffix;

    private TextMeshProUGUI text;

    private void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        text.text = prefix + " " + GameManager.instance.WrecksLeft + " " + suffix;
    }

}
