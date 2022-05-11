using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    private Vector3 _moveDirection;
    [SerializeField]
    private int _speed;

    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    // Update is called once per frame
    public void Update()
    {
        //addes the move direction scaled up by  the speed to position
        transform.position += MoveDirection * _speed * Time.deltaTime;
        //makes the rigidbodys velocity equal to the forward
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
}
