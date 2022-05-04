using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviourScript : MonoBehaviour
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
    public virtual void Update()
    {
        transform.position += MoveDirection * _speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
}
