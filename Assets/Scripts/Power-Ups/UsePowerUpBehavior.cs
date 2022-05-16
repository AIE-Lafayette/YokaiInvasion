using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class UsePowerUpBehavior : MonoBehaviour
{
    [SerializeField]
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
    public void Activate(params object[] arg)
    {
        if (_currentPowerUp is null)
            return;

        _currentPowerUp.Activate(arg);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ninja")
        {
            NinjaPowerUpBehavior enemyAbility = other.GetComponent<NinjaPowerUpBehavior>();
            if (enemyAbility)
            {
                GetComponent<NinjaPowerUpBehavior>().CurrentPowerUp = enemyAbility.CurrentPowerUp;
                Destroy(other.gameObject);
            }
            Activate();
        }
    }
}
