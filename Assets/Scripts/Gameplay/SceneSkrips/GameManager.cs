using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instace;

    public GameState State;

    public static event System.Action<GameState> OnGmaeStateChange;
    [SerializeField]
    private EnemySpawnerBehavior enemySpawnerBehavior1, enemySpawnerBehavior2,
                                 enemySpawnerBehavior3, enemySpawnerBehavior4,
                                 enemySpawnerBehavior5;

    private EnemyBehaviour _enemyBehaviour;
    private int _enemyCount;
    public Text _enemycount;
    private void Awake() { Instace = this;}
    private void Start()
    {
        _enemycount.text = "Enemies: " + _enemyCount.ToString();
        caculatePoint();
    }
    // Update is called once per frame
    void Update()
    {
        if (_enemyCount == 0)
        {
            setActiveSpawners();
        }
    }

    
    public void UpdateGamestate(GameState newState)
    {
        State = newState;
        switch (newState)
        {
            case GameState.Startmenu:
                SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
              //  SceneManager.SetActiveScene(SceneManager.GetSceneByName("DeathScene"));
                break;
            case GameState.SpawnWave:
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                break;
            case GameState.AdvanceForward:
                break;
            case GameState.EndScreen:
                SceneManager.LoadScene("DeathScene",LoadSceneMode.Single );
               // SceneManager.SetActiveScene(SceneManager.GetSceneAt(2));
                //SceneManager.SetActiveScene(SceneManager.GetSceneByName("DeathScene"));
                break;
            default:
                break;
        }
        OnGmaeStateChange?.Invoke(newState);
    }
    public void setActiveSpawners()
    {
        enemySpawnerBehavior1.IsActive = true;
        enemySpawnerBehavior2.IsActive = true;
        enemySpawnerBehavior3.IsActive = true;
        enemySpawnerBehavior4.IsActive = true;
        enemySpawnerBehavior5.IsActive = true;
    }
    public void caculatePoint()
    {
        _enemyCount = enemySpawnerBehavior1.EnemyCount +
                      enemySpawnerBehavior2.EnemyCount +
                      enemySpawnerBehavior3.EnemyCount +
                      enemySpawnerBehavior4.EnemyCount +
                      enemySpawnerBehavior5.EnemyCount;
    }
    public void AddPoint()
    {
        _enemyCount += 1;
        _enemycount.text = "Enemies: " + _enemyCount.ToString();
    }
    public void SubtractPoint()
    {
        _enemyCount -= 1;
        _enemycount.text = "Enemies: " + _enemyCount.ToString();
    }
}

public enum GameState { 
    Startmenu,
    SpawnWave,
    AdvanceForward,
    EndScreen
}