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
        //I am setting a tag for this so nothing can mess up Ravis's tests, However I do think we should use this tag instead
        //Of a ninja tag. The power ups should all activate the same afterall.
        else if (other.tag == "PowerUp")
        {
            PowerUpBehavior Ability = other.GetComponent<PowerUpBehavior>();
            if (Ability)
            {
                GetComponent<PowerUpBehavior>().CurrentPowerUp = Ability.CurrentPowerUp;
                Activate();
                Destroy(other.gameObject);
            }
        }
    }
}
