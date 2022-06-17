using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    public static EnviromentBehavior Instance;
    [SerializeField]
    private GameObject _enviromentRef;
    private Rigidbody _rigidbody;
    private int _hitCount;
    private void Awake() {Instance = this; }
    private void Start() {_rigidbody = GetComponent<Rigidbody>();}
    // Update is called once per frame
    /// <summary>
    /// When called it will set the speed of the newest eniroment to 40.
    /// </summary>
    void Update()
    {
        if (GameManager.Instace._advaceForwardTrue == true)
        {
            Instance.GetComponent<MovementBehavior>().Speed = 40;
            GameManager.Instace._advaceForwardTrue = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            //when the hit count go to 1 then stop
            _hitCount++;
            if (_hitCount <= 1)
            {
                GetComponent<MovementBehavior>().Speed = 0;
            }
        }
    }
}
