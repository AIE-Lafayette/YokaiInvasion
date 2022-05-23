using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHolderManager : MonoBehaviour
{
    public static EnemyHolderManager Instace;
    [SerializeField]
    private EnemySpawnerBehavior enemySpawnerBehavior1, enemySpawnerBehavior2,
                                 enemySpawnerBehavior3, enemySpawnerBehavior4,
                                 enemySpawnerBehavior5;

    [SerializeField]
    private int _timeToSpawnWaves;
    private void Awake() {Instace = this;}
    private void Start()
    {
        enemySpawnerBehavior1.TimeToSpawnWaves = _timeToSpawnWaves;
        enemySpawnerBehavior2.TimeToSpawnWaves = _timeToSpawnWaves;
        enemySpawnerBehavior3.TimeToSpawnWaves = _timeToSpawnWaves;
        enemySpawnerBehavior4.TimeToSpawnWaves = _timeToSpawnWaves;
        enemySpawnerBehavior5.TimeToSpawnWaves = _timeToSpawnWaves;
    }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        enemySpawnerBehavior1.IsActive = true;
        enemySpawnerBehavior2.IsActive = true;
        enemySpawnerBehavior3.IsActive = true;
        enemySpawnerBehavior4.IsActive = true;
        enemySpawnerBehavior5.IsActive = true;
    }

}
