using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private MovementBehavior _enemy;

    [SerializeField]
    private float _spawnTime = 5.0f;
    private float _timer = 0.0f;
    private void Update()
    {
        if (_timer >= _spawnTime)
        {
            MovementBehavior spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            _timer = 0.0f;
        }
        _timer += Time.deltaTime;

    }
}
