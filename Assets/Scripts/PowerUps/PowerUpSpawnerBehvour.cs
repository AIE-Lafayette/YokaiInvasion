using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnerBehvour : MonoBehaviour
{
    public static PowerUpSpawnerBehvour Instance;
    [SerializeField]
    private GameObject _powerUps;

    private void Awake() { Instance = this; }
    /// <summary>
    /// spawns a single enemy
    /// </summary>
    public void SpawnPower() {/*keeps adding in enemyes based on the waves*/GameObject spawnedEnemy = Instantiate(_powerUps, transform.position, transform.rotation);}
}
