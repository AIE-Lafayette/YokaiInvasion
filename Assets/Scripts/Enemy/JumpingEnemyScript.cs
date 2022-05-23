using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyScript : EnemyBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _jump;
    public bool _isGrounded = true;
    [SerializeField]
    private float _jumpForce;
    [SerializeField]
    private float _direction;

    public Vector3 Jump
    {
        get { return _jump; }
        set { _jump = value; }
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, _jumpForce, - _direction);
    }

    private void OnTriggerStay(Collider other)
    {
        _isGrounded = true;
    }

    private  void Update()
    {
        if (_isGrounded == true)
        {
            _rigidbody.AddForce(Jump * _jumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
    }
}
