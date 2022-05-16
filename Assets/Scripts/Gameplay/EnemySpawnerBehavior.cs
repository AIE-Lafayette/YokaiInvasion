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
    }
    //the abount of waves
    public int WaveCount
    {
        get { return _enemyNumberOfWaves; }
    }
    void Update()
    {
        
        _enemyCount = GameObject.FindGameObjectsWithTag("Enemy");
        if (_enemyCount.Length <= 0)
        {
            //keeps adding in enemyes based on the waves
            for (int i = 0; i <= _enemyNumberOfWaves; i++)
            {
                EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            }
            //incresse amount
            _enemyNumberOfWaves++;
            
        }
    }
}
