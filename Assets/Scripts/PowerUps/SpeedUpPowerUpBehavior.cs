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

    public override void Activate(params object[] arg)
    {
        //Instace();
        SpeedBuff();
    }

    private void Instace()
    {
        //_playerMovement.Instace;
    }

    private void SpeedBuff()
    {
        PlayerMovementBehavior.Instace.IncreaseSpeed(5);
        _active = true;
        TimeLeft();
    }

    private void TimeLeft()
    {
        if(_active)
        {
            RoutineBehaviour.Instance.StartNewTimedAction(args => Reset(), TimedActionCountType.UNSCALEDTIME, _timer);
        }
    }

    private void Reset()
    {
        PlayerMovementBehavior.Instace.IncreaseSpeed(-5);
    }
}
