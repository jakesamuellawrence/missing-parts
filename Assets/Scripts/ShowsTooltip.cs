using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowsTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Tooltip tooltip;

    private InputActions inputs;

    [TextArea(5, 10)]
    public string tooltipText;

    private void Awake() {
        inputs = new InputActions();
        inputs.Enable(); 
    }

    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("Entered Button");
        tooltip.SetText(tooltipText);
        tooltip.Show();
    }

    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("Exited button");
        tooltip.Hide();
    }
}
