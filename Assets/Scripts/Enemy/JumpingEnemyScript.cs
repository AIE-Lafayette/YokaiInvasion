using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemyScript : EnemyBehaviour
{
    [SerializeField]
    private Vector3 _offset;
    private Vector3 _startPos;
    private Vector3 _move;

    [SerializeField]
    private float _direction;
    private float  _lerpTime;

    private bool _isGrounded = false;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void OnCollisionStay(Collision collision)
    {
        _isGrounded = true;
    }

    private  void Update()
    {
        transform.position = Vector3.Lerp(_startPos, _startPos + _offset, Mathf.Cos(Time.time) * 0.5f + 0.5f);

        if (_isGrounded == true)
        {
            _isGrounded = false;
        }
        //if (_isGrounded == false)
        //{
        //    _move = new Vector3(0, 0, -_direction);
        //    transform.position += _move * Time.deltaTime;
        //    GetComponent<Rigidbody>().velocity = transform.forward;
        //}
            
    }
}
