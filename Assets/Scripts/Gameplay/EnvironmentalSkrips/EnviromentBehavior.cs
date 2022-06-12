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
        //RoutineBehaviour.Instance.StartNewTimedAction(args => DestroyTheEnviroment(), TimedActionCountType.UNSCALEDTIME, _lifeTime);
       // _arrayEnviromentRef = GameObject.FindGameObjectsWithTag("ToriGate");
       
        if ( EnvironmentSpawnerHolder.Instace.arrayEnviromentRef[1].active)
        {
            EnvironmentSpawnerHolder.Instace.arrayEnviromentRef[0].GetComponent<MovementBehavior>().Speed = 40;
        }

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
    //public void DestroyTheEnviroment()
    //{
    //    Destroy(_arrayEnviromentRef[0]);
    //}
}
