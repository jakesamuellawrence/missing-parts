using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedWhileActive : MonoBehaviour {

    private void OnEnable() {
        Debug.Log("Pausing because " + name + " opened");
        Time.timeScale = 0;
    }

    private void OnDisable() {
        Debug.Log("Unpausing because " + name + " closed");
        Time.timeScale = 1;
    }

}
