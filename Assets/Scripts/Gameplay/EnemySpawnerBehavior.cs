using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    public static EnemySpawnerBehavior EnemySpawnerInstance;
    //private GameObject[] _enemyCount;
    private int _enemyCount;
    [SerializeField]
    private EnemyBehaviour _enemy;
    private bool _isActive;
    //how meny enemies 
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    public int EnemyCount {get { return _enemyCount; }}
    private void Awake() {EnemySpawnerInstance = this;}
    private void Start()
    {
        IsActive = true;
        GameManager.Instace.caculatePoint();
    }
    void Update()
    {
        if (IsActive)
        {
            //keeps adding in enemyes based on the waves
            EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            //incresse amount
            GameManager.Instace.AddPoint();
            IsActive = false;
        }
    }

}
