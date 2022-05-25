using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuffPowerUPBehavior : PowerUpBehavior
{
    [SerializeField]
    ProjectitleBehaviour _bulletRef;
    FireBehaviour _gun;
    private bool _active = false;
    private float _timer;

    /// <summary>
    /// Chanages the values of the gun force and the bullet damage and scale
    /// </summary>
    public virtual void DamageBuff()
    {  
        _bulletRef.IncreaseDamage(10);
        //_gun.ForceNerf(5);
        _bulletRef.transform.localScale = new Vector3(3, 0.2f, 0.2f);
          _active = true;
        TimeLeft();
    }

    /// <summary>
    /// Increases the player damage and increases the bullet scale
    /// returns to base values after time has past
    /// </summary>
    /// <param name="arg"></param>
    public override void Activate(params object[] arg)
    {
        //gets a reference to the gun
        //SetOwner();
        //increases the damage, scale while dreasesing force
        DamageBuff();
    }

    //After a set time to returns to there normal values
    private void TimeLeft()
    {
        if (_active)
        {
            //A lot of cost to use so might have to change how the timer works
            Invoke("Reset", 5);
        }
    }

    /// <summary>
    /// returns the stats back to its base
    /// </summary>
    private void Reset()
    {
        _bulletRef.IncreaseDamage(-10);
        _bulletRef.transform.localScale = new Vector3(0.6f, 0.2f, 0.2f);
        //_gun.ForceNerf(-10);
    }

    /// <summary>
    /// Gets a refenece of the gun for the player
    /// </summary>
    private void SetOwner()
    {
        if (Owner.tag == "Player")
        {
            _gun = Owner.GetComponentInChildren<FireBehaviour>();
        }
    }
}
