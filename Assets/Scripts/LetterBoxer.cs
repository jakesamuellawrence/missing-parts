using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class LetterBoxer : MonoBehaviour {

    public Vector2 desiredAspectValues;

    new private Camera camera;

    private void Start() {
        camera = GetComponent<Camera>();

        Resize();
    }

    private void Update() {
        Resize();
    }

    private void Resize() {
        float desiredAspect = desiredAspectValues.x / desiredAspectValues.y;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / desiredAspect;

        if (scaleHeight < 1.0f) { // letterbox
            Rect rect = new Rect();

            rect.width = 1f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1f - scaleHeight) / 2f;

            camera.rect = rect;
        } else if (scaleHeight == 1) { // no boxing
            camera.rect = new Rect(0, 0, 1, 1);
        } else if (scaleHeight > 1.0f) { // pillbox
            float scaleWidth = 1f / scaleHeight;
            Rect rect = new Rect();

            rect.width = scaleWidth;
            rect.height = 1f;
            rect.x = (1f - scaleWidth) / 2f;
            rect.y = 0;

            camera.rect = rect;
        }

        camera.aspect = desiredAspect;

    }

    private void OnPreCull() {
        Rect letterboxed = camera.rect;
        Rect full = new Rect(0, 0, 1, 1);

        camera.rect = full;
        GL.Clear(false, false, Color.black);
        camera.rect = letterboxed;
    }

}
