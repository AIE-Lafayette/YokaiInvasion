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
    public static event System.Action<GameState> OnGmaeStateChange;//a varable to call when needeing the game states
    private EnemySpawnerBehavior enemySpawnerBehavior;
    private int _playerScore, _enemyCount, _waveCount;
    //[SerializeField]
    //private GameObject _player;
    
    public InputDelegateBehavior _inputDelegateBehavior;
    public Text _enemycount, _waveCounter;
    private void Awake()  { Instace = this; }
    private void Start()
    {
        _enemycount.text = "Score: " + _playerScore.ToString();
        _waveCounter.text = "Current Wave: " + _waveCount.ToString();
        caculatePoint();
    }
    // Update is called once per frame
    void Update()
    {
        if (_enemyCount == 0)
            UpdateGamestate(GameState.AdvanceForward);
    }
    /// <summary>
    /// updateds the game state by taking in a game state
    /// </summary>
    /// <param name="newState">Uses the enum GameState to change the states for the switch</param>
    public void UpdateGamestate(GameState newState)
    {
        State = newState;
        switch (newState)
        {
            case GameState.Startmenu:
                SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
                break;
            case GameState.MainGameScene:
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                break;
            case GameState.SpawnWave:
                
                EnemyHolderManager.Instace.setActiveSpawners();
                //_playerMovementBehavior.enabled = true;
                _inputDelegateBehavior.Enable();
                break;
            case GameState.AdvanceForward:
                 //_inputDelegateBehavior.enabled = false;
                _inputDelegateBehavior.Disable();
                //_playerMovementBehavior.enabled = false;
                increaseWaveCount();
                EnvironmentSpawnerHolder.Instace.setActiveSpawners();
                break;
            case GameState.EndScreen:
                SceneManager.LoadScene("DeathScene",LoadSceneMode.Single );
                break;
            default:
                break;
        }
        OnGmaeStateChange?.Invoke(newState);
    }
    //gets the amount of points the player has
    public void caculatePoint()
    {
        _enemyCount = enemySpawnerBehavior.EnemyCount;
    }
    /// <summary>
    /// incease the enemy count by 1 when called
    /// </summary>
    public void AddEnemyCount()
    {
        _enemyCount += 1;
        _enemycount.text = "Score: " + _playerScore.ToString();
    }
    /// <summary>
    /// adds 50 points to the score and descrease the enemy count by 1
    /// </summary>
    public void AddPoint()
    {
        _playerScore += 50;
        _enemyCount -= 1;
        _enemycount.text = "Score: " + _playerScore.ToString();
    }
    /// <summary>
    /// incease the wave count my 1 each time its called
    /// </summary>
    private void increaseWaveCount()
    {
        _waveCount++;
        _waveCounter.text = "WaveCount: " + _waveCount.ToString();
    }
}
/// <summary>
/// holds the values for the states of the game
/// </summary>
public enum GameState { 
    Startmenu,
    MainGameScene,
    SpawnWave,
    AdvanceForward,
    EndScreen
}