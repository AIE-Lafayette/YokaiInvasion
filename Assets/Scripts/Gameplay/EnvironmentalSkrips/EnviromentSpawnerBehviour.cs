using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehviour : MonoBehaviour
{
    public static EnviromentSpawnerBehviour Instace;
    [SerializeField]
    private EnviromentBehavior _enviromentRef;
    private float _timer;
    private bool timerIsReached, _isActive;
    
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
            RoutineBehaviour.Instance.StartNewTimedAction(args => Spawn(), TimedActionCountType.UNSCALEDTIME, 1);
            
            if (!IsActive)
            {
                GameManager.Instace.UpdateGamestate(GameState.SpawnWave);
            }
        }
    }
    /// <summary>
    /// spawns a instance of a enviroment reference
    /// </summary>
    void Spawn()
    {
        GameObject enviroment = Instantiate(_enviromentRef.gameObject, transform.position, transform.rotation);
    }
    
}
