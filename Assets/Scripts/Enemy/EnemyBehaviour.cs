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

    public float Damage { get { return _damage; } set { _damage = value; } }
    public float MaxHealth { get { return _healthBehavior.MaxHealth; } set { _healthBehavior.MaxHealth = value; } }
    public float Health { get { return _healthBehavior.Health; } set { _healthBehavior.Health = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Awake()
    {
        _healthBehavior = GetComponent<HealthBehavior>();
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
        //you will have to use the game manager to get the array of enemies
        if (!_enemyBehaviour)//if not enemy behaviour
            if (tag != other.tag)  //is the posistion of other and this the same
                _healthBehavior.TakeDamage(_damage);//decrements health
    }
}
