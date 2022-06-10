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
    private int _justAInt;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        RoutineBehaviour.Instance.StartNewTimedAction(args => Destroy(this), TimedActionCountType.UNSCALEDTIME, _lifeTime );
        if (GameManager.Instace._advaceForwardTrue == true)
        {
            GetComponent<MovementBehavior>().Speed = 40;
            GameManager.Instace._advaceForwardTrue = false;
        }
           
        //RoutineBehaviour.Instance.StartNewTimedAction(args => , TimedActionCountType.UNSCALEDTIME, 4);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            GetComponent<MovementBehavior>().Speed = 0;
        }
    }
}
