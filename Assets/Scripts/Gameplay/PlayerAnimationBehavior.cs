using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehavior : MonoBehaviour
{
    [SerializeField]
    private InputDelegateBehavior _playermovement;
    private PlayerControls _playerControls;
    [SerializeField]
    private Animator _animator;

    private void Awake()
    {
        //PlayerBehaviour1.OnDeath = () => _animator.SetTrigger("Win");
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("Speed", _playerControls.Player.Movement.triggered);

        _animator.SetBool("IsShooting", _playerControls.Player.Shoot.triggered);
    }
}
