using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    public PlayerBehaviour1 Instace;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _velocity;

    public float Speed
    {
        get { return _speed; }
        set { Speed = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction) 
    {
        _velocity = direction * _speed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
