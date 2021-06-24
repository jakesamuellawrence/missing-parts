using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrentCarDisplay : MonoBehaviour {

    private TextMeshProUGUI text;

    private void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        SetDefect(GameManager.instance.nextDefect);
    }

    private void SetDefect(DefectType defect) {
        string defectText = "";
        switch (defect) {
            case DefectType.AlwaysAccel:
                defectText += "Always accelerating";
                break;
            case DefectType.NoAccel:
                defectText += "No accelerator, starts with burst of speed";
                break;
            case DefectType.NoBrake:
                defectText += "No brakes";
                break;
            case DefectType.NoLeft:
                defectText += "Cannot turn left";
                break;
            case DefectType.None:
                defectText += "None";
                break;
            case DefectType.NoRight:
                defectText += "Cannot turn right";
                break;
            case DefectType.NoTraction:
                defectText += "Low traction and drag";
                break;
            case DefectType.PoorTurning:
                defectText += "Slow turning";
                break;
            default:
                defectText += "Havent added a description for this one ;)";
                break;
        }
        text.text = defectText;
    }

}
