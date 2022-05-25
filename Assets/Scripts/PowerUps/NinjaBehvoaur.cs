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
    public float Damage { get { return _damage; } set { _damage = value; } }
    /// <summary>
    /// The speed and direction of the game object.
    /// </summary>
    // public Vector3 MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
    private void Start()
    {
       // this.transform.parent = _player.transform;
       // gameObject.transform.SetParent(_player.transform);
       // _enemyBehaviour.transform.SetParent(_player.transform,true);
       // this.transform.SetParent(_player.transform,true);
        _enemyBehaviour.transform.parent = _player.transform;
    }
    // Update is called once per frame
    void Update()
    {
        RoutineBehaviour.Instance.StartNewTimedAction(args => Destroy(gameObject), TimedActionCountType.UNSCALEDTIME, 3);
    }
    /// <summary>
    /// called when the posistion of the other and the transform of the enemy is the same
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

    }
}
