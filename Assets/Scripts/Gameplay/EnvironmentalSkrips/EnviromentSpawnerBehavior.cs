using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehavior : MonoBehaviour
{
    public static EnviromentSpawnerBehavior Instace;
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

            Invoke("Spawn", 1);
            Invoke("Spawn", 3);
            if (!IsActive)
                GameManager.Instace.UpdateGamestate(GameState.SpawnWave);
        }
    }
    
    void Spawn()
    {
        GameObject enviroment = Instantiate(_enviromentRef.gameObject, transform.position, transform.rotation);
    }

}