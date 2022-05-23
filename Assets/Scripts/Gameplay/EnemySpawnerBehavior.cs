using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    public static EnemySpawnerBehavior EnemySpawnerInstance;
    private int _enemyCount;

    [SerializeField]
    private EnemyBehaviour[] _enemy;
    private bool _isActive;
    
    private int _TimeToSpawnWaves;

    /// <summary>
    /// amount of time till the enemy spawn for each wave
    /// </summary>
    public int TimeToSpawnWaves { get { return _TimeToSpawnWaves; } set{ _TimeToSpawnWaves = value; } }
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    /// <summary>
    /// amount of enemyies that were spawned
    /// </summary>
    public int EnemyCount {get { return _enemyCount; }}
    private void Awake() 
    {
        EnemySpawnerInstance = this;
    }
    private void Start()
    {
        IsActive = true;
        GameManager.Instace.caculatePoint();
    }
    void Update()
    {
        if (IsActive)
        {
            Invoke("SpawnEnemy", _TimeToSpawnWaves);
            //incresse amount
            GameManager.Instace.AddPoint();
            IsActive = false;
        }
    }
    /// <summary>
    /// spawns a single enemy
    /// </summary>
    private void SpawnEnemy()
    {
        //keeps adding in enemyes based on the waves
        EnemyBehaviour spawnedEnemy = Instantiate(_enemy[Random.Range(0,_enemy.Length)], transform.position, transform.rotation);
    }
    /// <summary>
    /// gives a randome value between 0 and 3
    /// This is being used for the array 
    /// </summary>
    private void Rand()
    {
        Random.Range(0, 3);
    }
}
