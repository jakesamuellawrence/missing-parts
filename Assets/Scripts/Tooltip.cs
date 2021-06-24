using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    public float margins;
    public GameObject GFX;

    private Canvas parentCanvas;
    private RectTransform parentRectTransform;

    private RectTransform rectTransform;
    private TextMeshProUGUI textComponent;

    private InputActions inputs;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        textComponent = GetComponentInChildren<TextMeshProUGUI>();
        parentCanvas = transform.parent.GetComponent<Canvas>();
        parentRectTransform = transform.parent.GetComponent<RectTransform>();
        if (parentCanvas == null) {
            Debug.LogError("parentCanvas is not canvas");
        }

        inputs = new InputActions();
        
        inputs.Enable();

        GFX.SetActive(false);
    }

    public void Show() {
        GFX.SetActive(true);
    }
    
    public void Hide() {
        GFX.SetActive(false);
    }

    private void Update () {
        setPosition();
    }

    private void setPosition() {
        inputs.Menus.MousePosition.Enable();
        Vector2 screenPos = inputs.Menus.MousePosition.ReadValue<Vector2>();
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform,
                                                                screenPos,
                                                                parentCanvas.worldCamera,
                                                                out localPos);
        rectTransform.localPosition = localPos;
    }

    public void SetText(string tooltipText) {
        Debug.Log("Text being set");
        textComponent.text = tooltipText;
        Canvas.ForceUpdateCanvases();
        Resize();
    }

    public void Resize() {
        textComponent.margin = new Vector4(margins, margins, margins, margins);
        rectTransform.sizeDelta = new Vector2((textComponent.preferredWidth + 2 * margins), (textComponent.preferredHeight + 2 * margins));
    }

}
