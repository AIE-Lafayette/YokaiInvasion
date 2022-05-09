using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
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
    void Update()
    {
        MoveDirection = new Vector3(0, 0, - _speed);
        transform.position += MoveDirection * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
}
