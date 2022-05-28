using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject _owner;
    private GameObject _visualPrefab;

    [SerializeField]
    private PowerUpBehavior _currentPowerUp;

    /// <summary>
    /// The current power up in use
    /// </summary>
    public PowerUpBehavior CurrentPowerUp
    {
        get { return _currentPowerUp; }
        set { _currentPowerUp = value; }
    }

    /// <summary>
    /// The current owner of the powerup
    /// </summary>
    public GameObject Owner
    {
        get { return _owner; }
        set { _owner = value; }
    }
    
    /// <summary>
    /// How the power up functions
    /// </summary>
    /// <param name="arg">The arguments to have the power up function</param>
    public virtual void Activate(params object[] arg)
    {
    }
}
