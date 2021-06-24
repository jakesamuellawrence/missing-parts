using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NextCarCard : MonoBehaviour {

    //public float yOffset;
    public GameObject[] defectTexts;
    public string[] adjectives;
    public string[] nouns;

    public GameObject previousText;

    private TextMeshProUGUI nameText;

    private void OnEnable() {
        nameText = GetComponent<TextMeshProUGUI>();
        RandomiseName();
        DisplayFacts();
    }

    //private void OnDisable() {
    //    if (previousText != null) {
    //        Destroy(previousText);
    //    }
    //}

    private void RandomiseName() {
        string adjective = adjectives[Random.Range(0, adjectives.Length)];
        string noun = nouns[Random.Range(0, nouns.Length)];

        nameText.text = adjective + " " + noun;
    }

    private void DisplayFacts() {
        DefectType defect = GameManager.instance.nextDefect;
        GameObject defectText = defectTexts[(int)defect];
        //float ypercent = yOffset / 1080f;
        //float newYOffset = ypercent * Screen.height;
        //Vector3 position = transform.position + new Vector3(0, newYOffset, 0);
        Vector3 position = previousText.transform.position;
        Destroy(previousText);
        previousText = Instantiate(defectText, position, Quaternion.identity, transform.parent);
    }

}
