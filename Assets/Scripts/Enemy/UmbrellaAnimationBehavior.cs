using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaAnimationBehavior : MonoBehaviour
{
    [SerializeField]
    private JumpingEnemyScript _enemyMovement;
    [SerializeField]
    private Animator _animator;

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", _enemyMovement.MoveDirection.magnitude);
        _animator.SetBool("IsGrounded", _enemyMovement.IsGrounded);
    }
}
