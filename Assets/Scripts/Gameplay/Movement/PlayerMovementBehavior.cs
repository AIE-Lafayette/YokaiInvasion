using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    public static PlayerMovementBehavior Instace;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    private int _lane;

    public float Speed
    {
        get { return _speed; }
        set { Speed = value; }
    }
    private void Awake()
    {
        Instace = this;
        _lane = 2;
    }
    public Vector3 Velocity 
    {
        get { return _velocity; }
    }
    public virtual float IncreaseSpeed(float SpeedIncrease)
    {
        _speed += SpeedIncrease;

        return SpeedIncrease;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction) 
    {
        // moving left
        if (_lane < 4)
        {
            if (_lane == 0)
            {

            }

            _lane--;
        }

        // moving right
        else if (_lane == 4)
        {
            if (_lane > 0)
            {

            }

            _lane++;
        }

        _velocity = direction * _speed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
