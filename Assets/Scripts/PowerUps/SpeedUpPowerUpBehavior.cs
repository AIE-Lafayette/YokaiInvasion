using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPowerUpBehavior : PowerUpBehavior
{
    private PlayerMovementBehavior _playerMovement;
    private bool _active;
    [SerializeField]
    private float _timer;
    
    /// <summary>
    /// Once activation is called it will use the speed up
    /// </summary>
    /// <param name="arg"></param>
    public override void Activate(params object[] arg)
    {
        SpeedBuff();
    }

    /// <summary>
    /// Increases the speed of the players movement and starts the timelimit left
    /// </summary>
    private void SpeedBuff()
    {
        PlayerMovementBehavior.Instace.IncreaseSpeed(5);
        _active = true;
        TimeLeft();
    }

    /// <summary>
    /// Once active is true it starts the timer once time is over removes the powerup
    /// </summary>
    private void TimeLeft()
    {
        if(_active)
        {
            RoutineBehaviour.Instance.StartNewTimedAction(args => Reset(), TimedActionCountType.UNSCALEDTIME, _timer);
        }
    }

    /// <summary>
    /// Sets the speed cal to its inital speed
    /// </summary>
    private void Reset()
    {
        PlayerMovementBehavior.Instace.IncreaseSpeed(-5);
    }
}
