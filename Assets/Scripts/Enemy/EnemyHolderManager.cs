using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHolderManager : MonoBehaviour
{
    public static EnemyHolderManager Instace;
    [SerializeField]
    private EnemySpawnerBehavior[] enemySpawnerBehavior;

    [SerializeField]
    private int _timeToSpawnWaves;
    private void Awake() { Instace = this; }
    private void Start()
    {
        //loops through the array...
        for (int i = 0; i < enemySpawnerBehavior.Length; i++)
        {
            //sets each index's Time to the time to spawn waves
            enemySpawnerBehavior[i].TimeToSpawnWaves = _timeToSpawnWaves;
        }
    }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        //loops through the array...
        for (int i = 0; i < enemySpawnerBehavior.Length; i++)
        {
            //sets each index's active to true
            enemySpawnerBehavior[i].IsActive = true;
        }
    }
}
