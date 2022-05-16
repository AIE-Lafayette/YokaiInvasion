using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    //the array that holds the enemies
    private GameObject[] _enemyCount;
    [SerializeField]
    private EnemyBehaviour _enemy;
    private int _enemyNumberOfWaves;
    //how meny enemies 

    public int EnemyCount
    {
        get { return _enemyCount.Length; }
        set { value = _enemyCount.Length; }
    }

    public int WaveCount
    {
        get { return _enemyNumberOfWaves; }
        set { value = _enemyNumberOfWaves; }
    }
    void Update()
    {
        
        _enemyCount = GameObject.FindGameObjectsWithTag("Enemy");
        if (_enemyCount.Length <= 0)
        {
            for (int i = 0; i <= _enemyNumberOfWaves; i++)
            {
                EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            }
            _enemyNumberOfWaves++;
            
        }
    }
}
