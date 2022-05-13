using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    private int _enemyCount;

    [SerializeField]
    private EnemyBehaviour _enemy;

 
    private void Update()
    {
        if (_enemyCount <= 0)
        {
            EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            _enemyCount++;

        }


    }
}
