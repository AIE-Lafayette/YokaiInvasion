using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private EnemyBehaviour _enemy;
    private GameManager _gamemanger;
    private bool _isActive;
    public bool IsActive 
    {
        get {return _isActive; }
        set { value = _isActive; }
    }


 
    private void Update()
    {
        if (_isActive = true)
        {
            for (int i = 0; i < _gamemanger.EnemyWaveCount; i++)
            {
                EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            }
           
            _isActive = false;

            return;
        }
    }
}
