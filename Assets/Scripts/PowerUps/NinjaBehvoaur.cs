using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaBehvoaur : MonoBehaviour
{
    [SerializeField]
    private float _damage;
    private PlayerMovementBehavior _PlayerMovementBehavior;
    [SerializeField]
    private GameObject _leftSpawnPoint, _rightSpawnPoint, _player, _enemyBehaviour;
    private Rigidbody _rigidbody;
    public float Damage { get { return _damage; } set { _damage = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    // public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _PlayerMovementBehavior = GetComponent<PlayerMovementBehavior>();
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
            _PlayerMovementBehavior.Move(3);

        if (other.tag == "WallR")
            _PlayerMovementBehavior.Move(-4);
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
