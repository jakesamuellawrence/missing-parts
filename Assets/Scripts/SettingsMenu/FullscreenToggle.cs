using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class FullscreenToggle : MonoBehaviour {

    private Toggle toggle;

    private void Awake() {
        toggle = GetComponent<Toggle>();
    }

    private void Start() {
        toggle.isOn = Screen.fullScreen;
        toggle.onValueChanged.AddListener(delegate {
            SetFullscreen(toggle.isOn);
        });
    }

    public void SetFullscreen(bool fullscreen) {
        Settings.StoreFullscreen(fullscreen);
    }

}
