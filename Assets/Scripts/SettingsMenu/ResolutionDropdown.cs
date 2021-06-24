using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Dropdown))]
public class ResolutionDropdown : MonoBehaviour {

    private TMP_Dropdown dropdown;
    private Resolution[] resolutions;

    private void Awake() {
        dropdown = GetComponent<TMP_Dropdown>();
        resolutions = Screen.resolutions;
    }

    private void Start() {
        SetDropdownOptions();
        dropdown.onValueChanged.AddListener(delegate {
            SetResolution(dropdown.value);
        });
    }

    private void SetDropdownOptions() {
        List<string> resolutionStrings = new List<string>();
        int currentResIndex = 0;
        foreach (Resolution resolution in resolutions) {
            resolutionStrings.Add(resolution.width.ToString() + "x" + resolution.height.ToString() + ", " + resolution.refreshRate + "Hz");
            if (IsCurrentRes(resolution)) {
                currentResIndex = Array.IndexOf(resolutions, resolution);
            }
            Debug.Log(Screen.currentResolution + ", " + resolution);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutionStrings);
        dropdown.value = currentResIndex;
    }

    public void SetResolution(int resolutionIndex) {
        Resolution res = resolutions[resolutionIndex];
        Settings.StoreResolution(res.width, res.height, res.refreshRate);
    }

    private bool IsCurrentRes(Resolution res) {
        return (Screen.width == res.width
                && Screen.height == res.height);
    }

}
