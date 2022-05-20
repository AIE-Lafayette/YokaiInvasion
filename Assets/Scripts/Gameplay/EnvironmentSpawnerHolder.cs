using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnviromentSpawnerBehavior _enviromentSpawnerBehavior, _enviromentSpawnerBehavior2;
                                 
    private void Awake() { Instace = this; }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        _enviromentSpawnerBehavior.IsActive = true;
        _enviromentSpawnerBehavior2.IsActive = true;

    }
}
