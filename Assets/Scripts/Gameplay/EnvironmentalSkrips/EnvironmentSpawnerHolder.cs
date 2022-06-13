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
    /// <summary>
    /// is the array
    /// </summary>
    public GameObject[] arrayEnviromentRef { get { return _arrayEnviromentRef; } set { _arrayEnviromentRef = value; } }

    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    private void Awake() { Instace = this; }
    private void Start()
    {
        _arrayEnviromentRef = GameObject.FindGameObjectsWithTag("ToriGate");
    }
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
    /// <summary>
    /// destorys the Enviroment in the enviroment array at the index of 0
    /// </summary>
    public void DestroyTheEnviroment()
    {
        _arrayEnviromentRef = GameObject.FindGameObjectsWithTag("ToriGate");
        Destroy(_arrayEnviromentRef[0]);
    }
}
