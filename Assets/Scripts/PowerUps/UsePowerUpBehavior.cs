using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class UsePowerUpBehavior : PowerUpBehavior
{
    /// <summary>
    /// Checks if there is a powerup in use and activates it
    /// </summary>
    /// <param name="arg">the argument that needs to be passed through</param>
    public override void Activate(params object[] arg)
    {
        if (CurrentPowerUp is null)
            return;

        CurrentPowerUp.Activate(arg);
    }

    //On collision with a powerUp it checks their tag and sets the currentPowerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rage")
        {
            PowerUpBehavior powerUp = other.GetComponent<PowerUpBehavior>();
            if (powerUp)
            {
                GetComponent<PowerUpBehavior>().CurrentPowerUp = powerUp.CurrentPowerUp;
                Activate();
                
            }
            Destroy(other.gameObject);
        }
    }
}
