using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputToSwitchMenus : MonoBehaviour {

    public InputAction action;

    public GameObject toActivate;

    private void Awake() {
        action.canceled += context => Trigger();
    }

    private void Trigger() {
        Debug.Log("Pressed Enter");
        gameObject.SetActive(false);
        toActivate.SetActive(true);
    }

    private void OnEnable() {
        action.Enable();
    }

    private void OnDisable() {
        action.Disable();
    }

}
