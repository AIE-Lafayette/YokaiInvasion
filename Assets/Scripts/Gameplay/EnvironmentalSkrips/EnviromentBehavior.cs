using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    public static EnviromentBehavior ToryGateInstace;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            _hitCount++;
            if (_hitCount <= 1)
            {
                for (int i = 0; i < EnviromentSpawnerBehviour.Instace._arrayEnviromentRef.Length; i++)
                {
                    GetComponent<MovementBehavior>().Speed = 0;
                }
            }
                
        }
    }
}
