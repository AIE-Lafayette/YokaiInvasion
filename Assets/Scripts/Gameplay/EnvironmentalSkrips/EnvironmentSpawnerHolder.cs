using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerHolder : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private EnviromentSpawnerBehviour[] _enviromentRef;
    private bool _isActive;
    private GameObject[] _arrayEnviromentRef;
    //how meny enemies 
    public GameObject[] arrayEnviromentRef { get { return _arrayEnviromentRef; } set { _arrayEnviromentRef = value; } }

    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    private void Awake() { Instace = this; }
    // Update is called once per frame
    private void Update()
    {
        _arrayEnviromentRef = GameObject.FindGameObjectsWithTag("ToriGate");
    }
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
    public void DestroyTheEnviroment()
    {
        _arrayEnviromentRef = GameObject.FindGameObjectsWithTag("ToriGate");
        Destroy(_arrayEnviromentRef[0]);
    }
}
