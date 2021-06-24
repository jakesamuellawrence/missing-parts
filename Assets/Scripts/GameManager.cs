using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameMode gameMode;

    public GameObject canvas;
    public GameObject carPrefab;
    public SpawnPoint spawnPoint;
    public GameObject GameOverCard;
    public GameObject scoreboardCard;
    public GameObject carsRemainingCard;
    public GameObject currentCarCard;
    public GameObject timerCard;
    public GameObject releaseReminderCard;

    public MusicTimer musicTimer;
    public AudioClip RushHourMusic;
    public AudioClip ClassicMusic;
    public AudioClip EndlessMusic;

    public DefectType nextDefect;
    private DefectType previousDefect;

    private InputActions inputs;

    private CarController currentCar;

    public int score = 0;
    public int allowedCrashes;

    private int carsParked = 0;
    private int carsWrecked = 0;

    public float WrecksLeft {
        get {
            return allowedCrashes - carsWrecked;
        }
    }

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }

        inputs = new InputActions();
        inputs.BetweenRounds.SpawnNewCar.performed += context => SpawnCar();
        inputs.BetweenRounds.Enable();
    }

    public void SetupGame(GameMode mode) {
        gameMode = mode;

        GetComponent<InputToSwitchMenus>().enabled = true;

        canvas.SetActive(true);
        musicTimer.gameObject.SetActive(true);

        releaseReminderCard.SetActive(true);
        scoreboardCard.SetActive(true);
        currentCarCard.SetActive(true);
        
        if (gameMode == GameMode.RushHour) {
            musicTimer.SetSong(RushHourMusic);
            musicTimer.SetLooping(false);
            musicTimer.onMusicFinished += EndGame;
            timerCard.SetActive(true);
        } else if (gameMode == GameMode.Classic) {
            musicTimer.SetSong(ClassicMusic);
            musicTimer.SetLooping(true);
            carsRemainingCard.SetActive(true);
        } else if (gameMode == GameMode.Endless) {
            musicTimer.SetSong(EndlessMusic);
            musicTimer.SetLooping(true);
        }

    }

    private void OnEnable() {
        inputs.Enable();
    }

    private void OnDisable() {
        inputs.Disable();
    }

    public void EndGame() {
        if (currentCar != null) {
            currentCar.TurnIntoObstacle();
        }
        inputs.BetweenRounds.Disable();

        scoreboardCard.SetActive(false);
        carsRemainingCard.SetActive(false);
        currentCarCard.SetActive(false);
        timerCard.SetActive(false);
        GameOverCard.SetActive(true);
    }

    public void ExitToMenu() {
        SceneManager.MoveGameObjectToScene(transform.parent.gameObject, SceneManager.GetActiveScene());
        SceneManager.LoadScene(SceneNames.instance.MainMenu);
    }

    private void UpdateScore() {
        CarController[] cars = FindObjectsOfType<CarController>();
        carsParked = 0;
        carsWrecked = 0;
        foreach (CarController car in cars) {
            if (car.parked) {
                carsParked++;
            }
            if (car.wrecked) {
                carsWrecked++;
            }
        }
        if (gameMode == GameMode.RushHour) {
            score = carsParked - carsWrecked;
        } else {
            score = carsParked;
        }
    }

    public void EndRound() {
        Debug.Log("Round Ended");
        UpdateScore();
        if (gameMode == GameMode.Classic && carsWrecked >= allowedCrashes) {
            EndGame();
            return;
        }
        inputs.BetweenRounds.Enable();
        ChooseNextDefect();
        releaseReminderCard.SetActive(true);
    }

    private void ChooseNextDefect() {
        while (nextDefect == previousDefect) {
            nextDefect = nextDefect = (DefectType)Random.Range(0, (int)DefectType.END);
        }
        //nextDefect = DefectType.NoAccel;
        previousDefect = nextDefect;
    }

    private void SpawnCar() {
        if (spawnPoint == null) {
            spawnPoint = FindObjectOfType<SpawnPoint>();
        }
        if (musicTimer.started == false) {
            musicTimer.StartTimer();
        }
        Debug.Log("Car Spawned");
        releaseReminderCard.SetActive(false);
        GameObject car = spawnPoint.Spawn(carPrefab);
        CarController carController = car.GetComponent<CarController>();
        currentCar = carController;
        carController.GiveDefect(nextDefect);
        inputs.BetweenRounds.Disable();
    }

}
