using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    //the array that holds the enemies
    private GameObject[] _enemyCount;
    [SerializeField]
    private EnemyBehaviour _enemy;
    private bool _isActive = false;
    private int _enemyNumberOfWaves;
    //how meny enemies 
    public bool IsActive
    {
        get {return _isActive; }
        set {_isActive = value; }
    }
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
        if (IsActive)
        {
            //keeps adding in enemyes based on the waves
            for (int i = 0; i <= _enemyNumberOfWaves; i++)
            {
                EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            }
            //incresse amount
            _enemyNumberOfWaves++;
            IsActive = false;
        }
    }
}
