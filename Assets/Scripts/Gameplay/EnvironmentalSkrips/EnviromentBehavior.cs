using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    public static EnviromentBehavior ToryGateInstace;
    [SerializeField]
    private GameObject _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private GameManager _gameManager;
    private EnvironmentSpawnerHolder _environmentSpawnerHolder;
    private float _timer;
   
    private int _hitCount;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        //here is the null error
        if ( EnvironmentSpawnerHolder.Instace.arrayEnviromentRef[1].activeInHierarchy == true)
            EnvironmentSpawnerHolder.Instace.arrayEnviromentRef[0].GetComponent<MovementBehavior>().Speed = 40;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            _hitCount++;
            if (_hitCount <= 1)
                GetComponent<MovementBehavior>().Speed = 0;
        }
    }
}
