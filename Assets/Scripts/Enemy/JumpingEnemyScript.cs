using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyScript : EnemyBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _jump;
    private float _timer = 2.5f;
    private bool _isGrounded = false;

    [SerializeField]
    private float _direction;
    [SerializeField]
    private float _jumpForce;

    public bool IsGrounded { get => _isGrounded; }

    public Vector3 Jump
    {
        get { return _jump; }
        set { _jump = value; }
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, _jumpForce, -_direction);
    }

    private void Update()
    {
        //If the enemy is on the ground
        if (_isGrounded == true)
        {
            //if the timer is above 0
            if(_timer > 0f)
            {
                //count down
                _timer -= Time.deltaTime;
            }
            else
            {
                //add jumping force
                _rigidbody.AddForce(Jump * _jumpForce, ForceMode.Impulse);
                //set the _IsGrounded to be false
                _isGrounded = false;
                //restart the timer
                _timer = 2.5f;
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
            _isGrounded = true;
    }
}
