using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    private GameObject[] _enemyCount;

    [SerializeField]
    private EnemyBehaviour _enemy;


    private void Update()
    {
        _enemyCount = GameObject.FindGameObjectsWithTag("Enemy");
        if (_enemyCount.Length <= 0)
        {
            EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);

            return;
        }
    }
}
