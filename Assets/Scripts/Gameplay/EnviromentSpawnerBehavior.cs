using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private float _timer;

    // Update is called once per frame
    void Update()
    {
        //The higher the timer the long it takes to spawn
        _timer += Time.deltaTime;

        //only spawns when the timer is greater than lifeTime
        if (_timer >= _lifeTime)
        {
            //instatiats the enviroment and the position that it spawns, and its rotation.
            GameObject enviroment = Instantiate(_enviromentRef.gameObject, transform.position, transform.rotation);
            //resets timer
            _timer = 0;
        }
    }
}
