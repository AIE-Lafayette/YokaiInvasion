using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehavior : MonoBehaviour
{
    [SerializeField]
    private InputDelegateBehavior _playermovement;
    [SerializeField]
    private Animator _animator;

    private void Awake()
    {
        //PlayerBehaviour1.OnDeath = () => _animator.SetTrigger("Death");
    }

    //Goes through the animations of the player
    void Update()
    {
        //While not moving it idles and when moving it dashes
        _animator.SetBool("IsMoving", _playermovement.IsMoving);

        //while not shoooting it idles and when it does starts attack animation
        _animator.SetBool("IsShooting", _playermovement.IsShooting);
    }
}
