using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    //the array that holds the enemies
    private GameObject[] _enemyCount;
    [SerializeField]
    private EnemyBehaviour _enemy;
    //how meny enemies that spawn in the wave
    public int EnemyWaveCount
    {
        get { return _enemyCount.Length; }
        set { value = _enemyCount.Length; }
    }
    private void Update()
    {
        if (_enemyCount.Length <= 0)
        {
            for (int i = 0; i < EnemyWaveCount; i++)
            {
                EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            }

            
        }
    }
}
