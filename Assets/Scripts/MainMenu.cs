using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private AsyncOperation asyncOp;
    
    public void PlayRushHour() {
        GameManager.instance.SetupGame(GameMode.RushHour);
        LoadInGame();
    }

    public void PlayClassic() {
        GameManager.instance.SetupGame(GameMode.Classic);
        LoadInGame();
    }

    public void PlayEndless() {
        GameManager.instance.SetupGame(GameMode.Endless);
        LoadInGame();
    }

    private void Update() {
        if (asyncOp != null) {
            //Debug.Log("Progress: " + asyncOp.progress);
        }
    }

    private void Start() {
        //PreloadInGame();
    }

    private void LoadInGame() {
        if (asyncOp != null) {
            asyncOp.allowSceneActivation = true;
        } else {
            Debug.Log("Scene not being preloaded!!!");
            SceneManager.LoadScene(SceneNames.instance.SmallArena);
        }
    }

    public void PreloadInGame() {
        Debug.Log("Preloading InGame scene");
        asyncOp = SceneManager.LoadSceneAsync(SceneNames.instance.SmallArena);
        asyncOp.allowSceneActivation = false;
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Quit!");
    }

}
