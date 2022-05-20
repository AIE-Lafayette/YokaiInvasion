using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpBehavior : PowerUpBehavior
{
    private UsePowerUpBehavior _abilityScript;
    public PlayerMovementBehavior _player;

    //private void Awake()
    //{
    //    _abilityScript.CurrentPowerUp = new SpeedPowerUpBehavior();
    //}

    public override void Activate(params object[] arguments)
    {
        _player.Speed = 13;
    }
}
