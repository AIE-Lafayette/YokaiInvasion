using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaSpawnerBehviour : MonoBehaviour
{
    public static NinjaSpawnerBehviour NinjaSpawnerInstance;
    [SerializeField]
    private GameObject[] _gameObjects;
    private bool _isActive;
    /// <summary>
    /// amount of time till the enemy spawn for each wave
    /// </summary>
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }

    private void Awake()
    {
        NinjaSpawnerInstance = this;

    }
    private void Start()
    {
        IsActive = false;
    }
    void Update()
    {
        if (IsActive)
        {
            SpawnNinja();
            IsActive = false;
        }
    }
    /// <summary>
    /// spawns a single enemy
    /// </summary>
    public void SpawnNinja()
    {
        //keeps adding in enemyes based on the waves
        GameObject spawnedEnemy = Instantiate(_gameObjects[0], transform.position,transform.rotation);
    }
}
