using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaBehvoaur : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyBehaviour;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private GameObject _player;
    private Rigidbody _rigidbody;
    public float Damage { get { return _damage; } set { _damage = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    // public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (this == null)
            return;
        RoutineBehaviour.Instance.StartNewTimedAction(args => Destroy(gameObject), TimedActionCountType.UNSCALEDTIME, 3);
    }
}
