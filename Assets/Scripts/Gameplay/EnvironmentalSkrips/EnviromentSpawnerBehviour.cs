using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehviour : MonoBehaviour
{
    public static EnviromentSpawnerBehviour Instace;
    private float _timer;
    private bool timerIsReached, _isActive;
    public GameObject[] _arrayEnviromentRef;
    //how meny enemies 
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    private void Awake() { Instace = this; }

    // Update is called once per frame
    void Update()
    {
        //The higher the timer the long it takes to spawn
        if (IsActive)
        {
            _isActive = false;
            RoutineBehaviour.Instance.StartNewTimedAction(args => MoveEnviroment(), TimedActionCountType.UNSCALEDTIME, 1);
            
            if (!IsActive)
            {
                GameManager.Instace.UpdateGamestate(GameState.SpawnWave);
            }
        }
    }
    /// <summary>
    /// spawns a instance of a enviroment reference
    /// </summary>
    void MoveEnviroment()
    {
        for (int i = 0; i < _arrayEnviromentRef.Length; i++)
        {
            _arrayEnviromentRef[i].GetComponent<MovementBehavior>().Speed = 40;
        }
    }
    
}
