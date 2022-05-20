using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    public static EnemySpawnerBehavior EnemySpawnerInstance;
    //the array that holds the enemies
    //private GameObject[] _enemyCount;
    private int _enemyCount;
    [SerializeField]
    private EnemyBehaviour _enemy;
    public static bool _isActive;
    private int _enemyNumberOfWaves;
    //how meny enemies 
    public bool IsActive {get {return _isActive; } set { _isActive = value; } }
    public int EnemyCount {get { return _enemyCount; }}
    //the abount of waves
    public int WaveCount{ get { return _enemyNumberOfWaves; }}
    private void Awake() { EnemySpawnerInstance = this;}
    private void Start()
    {
        SettheSetActive();
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
    public void SettheSetActive()
    {
        GameManager.Instace.setActiveSpawners(this);
    }
}
