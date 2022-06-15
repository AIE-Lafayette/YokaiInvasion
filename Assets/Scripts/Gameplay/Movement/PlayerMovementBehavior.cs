using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    public static PlayerMovementBehavior Instace;

    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    private int _lane = 2;
    public GameObject[] _lanes;
    private Vector3[] _lanePos;
    float _time = 1;
    [SerializeField]
    float _speed;


    private void Awake()
    {
        Instace = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 position)
    {

       transform.position = Vector3.Lerp(position, _lanes[_lane].transform.position, _time += Time.deltaTime * _speed);
        
         
    }
    /// <summary>
    /// Needed for the constent motion
    /// </summary>
    // Update is called once per frame
    void FixedUpdate()
    {
        //_rigidbody.MovePosition(transform.position + _velocity);
    }
}
