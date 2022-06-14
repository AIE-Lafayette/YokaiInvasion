using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    private Vector3 _moveDirection;
    [SerializeField]
    private int _speed;


    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }

    // Update is called once per frame
    public void Update()
    {
        //makes movedirection into a new vecotor3 that uses speed to move
        MoveDirection = new Vector3(0, 0, -_speed);
        //addes the move direction scaled up by  the speed to position
        transform.position += MoveDirection * Time.deltaTime;
        //makes the rigidbodys velocity equal to the forward
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
}
