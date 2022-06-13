using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaBehvoaur : PowerUpBehavior
{
    [SerializeField]
    private float _damage;
    private PlayerMovementBehavior _PlayerMovementBehavior;
    [SerializeField]
    private GameObject _leftSpawnPoint, _rightSpawnPoint, _player;
    private GameObject _enemyBehaviour;
    private Rigidbody _rigidbody;
    
    public float Damage { get { return _damage; } set { _damage = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    // public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _PlayerMovementBehavior = _player.GetComponent<PlayerMovementBehavior>();
    }
    // Update is called once per frame
    void Update()
    {
        if (this == null)
            return;
        RoutineBehaviour.Instance.StartNewTimedAction(args => ResetGameObject(), TimedActionCountType.UNSCALEDTIME, 10);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WallL")
        {
            if (tag == "NinjaL")
                transform.position = new Vector3(1, transform.position.y, transform.position.z);
            if (tag == "NinjaR")
                transform.position = new Vector3(4, transform.position.y, transform.position.z);
        }
        //_PlayerMovementBehavior.Move(1);

        if (other.tag == "WallR")
        {
            if (tag == "NinjaL")
                transform.position = new Vector3(-2, transform.position.y, transform.position.z);
            if (tag == "NinjaR")
                transform.position = new Vector3(1, transform.position.y, transform.position.z);
        }
    }
    /// <summary>
    /// Resets the posistion of the ninjas
    /// </summary>
    private void ResetGameObject() 
    {
        if (gameObject.tag == "NinjaL")
           transform.position = _leftSpawnPoint.transform.position;
        if (gameObject.tag == "NinjaR")
            transform.position = _rightSpawnPoint.transform.position;
        gameObject.SetActive(false);
    }
}
