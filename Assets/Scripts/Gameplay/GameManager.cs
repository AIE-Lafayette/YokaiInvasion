using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    public Text _enemycount;
    [SerializeField]
    private float HealthLimit;

    // Update is called once per frame
    void Update()
    {
        //then print the text 
        _enemycount.text = "Enemies: " + (enemySpawnerBehavior1.EnemyCount + 
                                          enemySpawnerBehavior2.EnemyCount + 
                                          enemySpawnerBehavior3.EnemyCount + 
                                          enemySpawnerBehavior4.EnemyCount +
                                          enemySpawnerBehavior5.EnemyCount).ToString();
        //if the start timer is greater than or equal to the max timer 
        if (enemySpawnerBehavior1.EnemyCount <= 0)
        {
            ////max health is less than the health limit 
            //if (_enemyBehaviour.MaxHealth <= HealthLimit)
            //    _enemyBehaviour.MaxHealth += 2;//plus 2 to max health *or decrease here*
            setActiveSpawners();
        }
    }

    public void setActiveSpawners()
    {
        enemySpawnerBehavior1.IsActive = true;
        enemySpawnerBehavior2.IsActive = true;
        enemySpawnerBehavior3.IsActive = true;
        enemySpawnerBehavior4.IsActive = true;
        enemySpawnerBehavior5.IsActive = true;
    }
    public void UpdateGamestate(GameState newState)
    {
        State = newState;
        switch (newState)
        {
            case GameState.Startmenu:
                SceneManager.SetActiveScene(SceneManager.GetSceneByName("StartScene"));
                break;
            case GameState.SpawnWave:
                break;
            case GameState.AdvanceForward:
                break;
            case GameState.EndScreen:
                SceneManager.SetActiveScene(SceneManager.GetSceneByName("DeathtScene"));
                break;
            default:
                break;
        }
        OnGmaeStateChange?.Invoke(newState);
    }
}

public enum GameState { 
    Startmenu,
    SpawnWave,
    AdvanceForward,
    EndScreen
}