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
        SpeedBuff();
    }

    private void SpeedBuff()
    {
        _playerMovement.IncreaseSpeed(5);
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
        _playerMovement.IncreaseSpeed(-5);
    }
}
