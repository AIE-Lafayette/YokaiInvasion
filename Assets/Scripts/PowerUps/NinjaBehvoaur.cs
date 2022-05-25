using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaBehvoaur : MonoBehaviour
{
    [SerializeField]
    private NinjaBehvoaur _enemyBehaviour;
    [SerializeField]
    private float _damage;

    public float Damage { get { return _damage; } set { _damage = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    // public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //makes movedirection into a new vecotor3 that uses speed to move
        //MoveDirection = new Vector3(0, 0, -_speed);
        ////addes the move direction scaled up by  the deltatime to position
        //transform.position += MoveDirection * Time.deltaTime;
        ////makes the rigidbodys velocity equal to the forward
        //GetComponent<Rigidbody>().velocity = transform.forward;
    }
    /// <summary>
    /// called when the posistion of the other and the transform of the enemy is the same
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

    }
}
