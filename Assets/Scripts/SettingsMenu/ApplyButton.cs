using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyButton : MonoBehaviour {

    private Button button;

    private void Awake() {
        button = GetComponent<Button>();
    }

    private void Start() {
        button.onClick.AddListener(delegate {
            Apply();
        });
    }

    public void Apply() {
        Settings.SaveSettings();
        Settings.LoadSettings();
    }

}
