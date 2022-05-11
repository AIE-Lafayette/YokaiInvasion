using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyBehaviour _enemyBehaviour;
    [SerializeField]
    private float _damage;
    private HealthBehavior _healthBehavior;
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

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //makes movedirection into a new vecotor3 that uses speed to move
        MoveDirection = new Vector3(0, 0, -_speed);
        //addes the move direction scaled up by  the deltatime to position
        transform.position += MoveDirection * Time.deltaTime;
        //makes the rigidbodys velocity equal to the forward
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
    /// <summary>
    /// called when the posistion of the other and the transform of the enemy is the same
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (!_enemyBehaviour)//if not enemy behaviour
        {
            //is the posistion of other and this the same
            if (transform.position == other.transform.position)
                _healthBehavior.TakeDamage(_damage);//decrements health
        }
    }
}
