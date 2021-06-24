using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNames : MonoBehaviour {

    public static SceneNames instance;

    public string MainMenu;
    public string SmallArena;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
    }

}
