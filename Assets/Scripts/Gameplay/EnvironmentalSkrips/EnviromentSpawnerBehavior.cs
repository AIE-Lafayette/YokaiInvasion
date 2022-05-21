using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehavior : MonoBehaviour
{
    public static EnviromentSpawnerBehavior Instace;
    [SerializeField]
    private EnviromentSpawnerBehavior _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private float _timer;
    private bool _isActive;
    //how meny enemies 
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }
    private void Awake() {Instace = this;}
    // Update is called once per frame
    void Update()
    {
        //The higher the timer the long it takes to spawn
        _timer += Time.deltaTime;
        if (IsActive && _timer > 8)
        {
            // instatiats the enviroment and the position that it spawns, and its rotation.
            GameObject enviroment = Instantiate(_enviromentRef.gameObject, transform.position, transform.rotation);
            _isActive = false;
            if (_timer >= 10)
            {
                GameManager.Instace.UpdateGamestate(GameState.SpawnWave);
                _timer = 0;
            }
        }
        
    }

}