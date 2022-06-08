using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _enviromentRef;
    [SerializeField]
    private float _lifeTime;
    private float _timer;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        RoutineBehaviour.Instance.StartNewTimedAction(args => Destroy(this), TimedActionCountType.UNSCALEDTIME, _lifeTime );
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            GetComponent<MovementBehavior>().Speed = 0;
            
            RoutineBehaviour.Instance.StartNewTimedAction(args => GetComponent<MovementBehavior>().enabled = false, TimedActionCountType.UNSCALEDTIME, 10);
        }
    }
}
