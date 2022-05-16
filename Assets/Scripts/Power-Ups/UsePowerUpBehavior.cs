using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePowerUpBehavior : PowerUpBehavior
{
    private PowerUpBehavior _currentPowerUp;

    public PowerUpBehavior CurrentPowerUp
    {
        get { return _currentPowerUp; }
        set { _currentPowerUp = value; }
    }

    /// <summary>
    /// Activates the current powerUp
    /// </summary>
    /// <param name="arg">the argument that needs to be passed through</param>
    public override void Activate(params object[] arg)
    {
        _currentPowerUp.Activate(arg);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ninja")
        {
            _currentPowerUp = new NinjaPowerUpBehavior();
            Activate();
        }
    }
}
