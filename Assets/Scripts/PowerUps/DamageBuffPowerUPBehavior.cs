using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuffPowerUPBehavior : PowerUpBehavior
{
    [SerializeField]
    ProjectitleBehaviour _bulletRef;
    private bool _active = false;

    /// <summary>
    /// Chanages the values of the gun force and the bullet damage and scale
    /// </summary>
    public virtual void DamageBuff()
    {
        _bulletRef.IncreaseDamage(10);
        FireBehaviour.instance.ForceNerf(5);
        _bulletRef.GetComponentInChildren<TrailRenderer>().startColor = Color.red;
        _active = true;
        TimeLeft();
    }

    /// <summary>
    /// Increases the player damage and increases the bullet scale
    /// returns to base values after time has past
    /// </summary>
    /// <param name="arg"></param>
    public override void Activate(params object[] arg) { /*increases the damage, scale while dreasesing force*/ DamageBuff(); }

    //After a set time to returns to there normal values
    private void TimeLeft()
    {
        if (_active)
            RoutineBehaviour.Instance.StartNewTimedAction(args => Reset(), TimedActionCountType.UNSCALEDTIME, Timer);
        
    }

    /// <summary>
    /// returns the stats back to its base
    /// </summary>
    private void Reset()
    {
        _bulletRef.IncreaseDamage(-10);
        FireBehaviour.instance.ForceNerf(-5);
        _bulletRef.GetComponentInChildren<TrailRenderer>().startColor = Color.cyan;
    }
}
