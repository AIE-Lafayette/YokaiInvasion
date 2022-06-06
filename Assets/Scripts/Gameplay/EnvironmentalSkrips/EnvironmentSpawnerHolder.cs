using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnviromentSpawnerBehviour[] _enviromentRef;
    private bool _isActive;

    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    private void Awake() { Instace = this; }
    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        for (int i = 0; i < _enviromentRef.Length; i++)
        {
            _enviromentRef[i].IsActive = true;//set each index to true
        }
        
    }
}
