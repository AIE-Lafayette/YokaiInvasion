using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class UsePowerUpBehavior : PowerUpBehavior
{
    /// <summary>
    /// Activates the current powerUp
    /// </summary>
    /// <param name="arg">the argument that needs to be passed through</param>
    public override void Activate(params object[] arg)
    {
        if (CurrentPowerUp is null)
            return;

        CurrentPowerUp.Activate(arg);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rage")
        {
            //PowerUpBehavior powerUp = other.GetComponent<PowerUpBehavior>();
            //if (powerUp)
            //{
            //    GetComponent<PowerUpBehavior>().CurrentPowerUp = powerUp.CurrentPowerUp;
            //    Activate();

            //}

            Destroy(other.gameObject);
        }
    }
}
