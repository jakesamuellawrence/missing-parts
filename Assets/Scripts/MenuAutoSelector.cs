using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuAutoSelector : MonoBehaviour {

    public GameObject selectOnOpen;

    private GameObject lastSelected;

    private void OnEnable() {
        if (lastSelected == null) {
            StartCoroutine(SelectButton(selectOnOpen));
        } else {
            StartCoroutine(SelectButton(lastSelected));
        }
    }

    private void Update() {
        lastSelected = EventSystem.current.currentSelectedGameObject;
    }

    private IEnumerator SelectButton(GameObject button) {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(button);
    }
}
