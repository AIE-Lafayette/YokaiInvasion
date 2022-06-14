using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    public static EnviromentBehavior Instance;
    [SerializeField]
    private GameObject _enviromentRef;
    private Rigidbody _rigidbody;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        if (GameManager.Instace.State != GameState.AdvanceForward)
            GetComponent<MovementBehavior>().Speed = 0;
        if (GameManager.Instace.State == GameState.AdvanceForward)
            GetComponent<MovementBehavior>().Speed = 20;
    }
    // Update is called once per frame
    void Update()
    {
       
        if (GameManager.Instace._advaceForwardTrue == true)
        {
            Instance.GetComponent<MovementBehavior>().Speed = 40;
            GameManager.Instace._advaceForwardTrue = false;
        }
           
        //RoutineBehaviour.Instance.StartNewTimedAction(args => , TimedActionCountType.UNSCALEDTIME, 4);
        
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
