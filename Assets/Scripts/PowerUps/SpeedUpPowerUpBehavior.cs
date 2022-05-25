using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPowerUpBehavior : PowerUpBehavior
{
    [SerializeField]
    private PlayerMovementBehavior _playerMovement;
    private bool _active;

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
            Invoke("Reset", 5);
        }
    }

    private void Reset()
    {
        _playerMovement.IncreaseSpeed(-5);
    }
}
