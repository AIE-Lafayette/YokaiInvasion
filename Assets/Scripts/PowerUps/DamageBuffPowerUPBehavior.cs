using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuffPowerUPBehavior : MonoBehaviour
{
    [SerializeField]
    ProjectitleBehaviour _bulletRef;
    [SerializeField]
    private float _damageBuff;
    [SerializeField]
    FireBehaviour _gun;
    [SerializeField]
    private float _forceNerf;


    public virtual void DamageBUff()
    {
        _damageBuff += _bulletRef.Damage;
        _forceNerf += _gun.BulletForce;
        _bulletRef.transform.localScale.Set(2.2f, 1.5f, 1.5f);
    }
}
