using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaAnimationBehavior : MonoBehaviour
{
    [SerializeField]
    private NinjaBehvoaur _ninjaMovement;
    [SerializeField]
    private Animator _animator;


    private void Update()
    {
        _animator.SetBool("Shoot", _ninjaMovement.Shoot);
    }
}
