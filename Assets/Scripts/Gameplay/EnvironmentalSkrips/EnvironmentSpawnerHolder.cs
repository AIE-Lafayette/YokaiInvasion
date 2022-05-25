using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnviromentSpawnerBehavior[] _enviromentSpawnerBehavior;
                                 
    private void Awake() { Instace = this; }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        //gos through the array and...
        for (int i = 0; i < _enviromentSpawnerBehavior.Length; i++)
        {
            _enviromentSpawnerBehavior[i].IsActive = true;//set each index to true
        }
    }
}
