using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnemySpawnerBehavior enemySpawnerBehavior1, enemySpawnerBehavior2,
                                 
    private void Awake() { Instace = this; }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        enemySpawnerBehavior1.IsActive = true;
        enemySpawnerBehavior2.IsActive = true;
    }
}
