using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehavior : MonoBehaviour
{
    public static EnvironmentSpawnerHolder Instace;
    [SerializeField]
    private GameObject _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private float _timer;
    private bool _isActive;
    //how meny enemies 
    public bool IsActive { get { return _isActive; } set { _isActive = value; } }

    // Update is called once per frame
    void Update()
    {
        //The higher the timer the long it takes to spawn
        _timer += Time.deltaTime;
        if (IsActive)
        {
          //  only spawns when the timer is greater than lifeTime
            if (_timer >= _lifeTime)
            {
               // instatiats the enviroment and the position that it spawns, and its rotation.
                GameObject enviroment = Instantiate(_enviromentRef.gameObject, transform.position, transform.rotation);
               // resets timer
                _timer = 0;
                _isActive = false;
            }
            //make the enemy spawners start again
        }
    }
}
