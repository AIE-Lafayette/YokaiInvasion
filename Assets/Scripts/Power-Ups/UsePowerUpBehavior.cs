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
    public void Activate(params object[] arg)
    {
        //if (_currentPowerUp is null)
        //    return;

        CurrentPowerUp.Activate(arg);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ninja")
        {
            PowerUpBehavior enemyAbility = other.GetComponent<PowerUpBehavior>();
            if (enemyAbility)
            {
                GetComponent<PowerUpBehavior>().CurrentPowerUp = enemyAbility.CurrentPowerUp;
                Activate();
                Destroy(other.gameObject);
            }
        }
    }
}
