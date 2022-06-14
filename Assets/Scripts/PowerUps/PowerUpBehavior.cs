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

    [SerializeField]
    private float _timer;

    private bool _checkActive;
    public bool CheckActive { get { return _checkActive; } set { _checkActive = value; } }
    public float Timer { get { return _timer; } set { _timer = value; } }
    /// <summary>
    /// The current power up in use
    /// </summary>
    public PowerUpBehavior CurrentPowerUp { get { return _currentPowerUp; } set { _currentPowerUp = value; } }

    /// <summary>
    /// The current owner of the powerup
    /// </summary>
    public GameObject Owner { get { return _owner; } set { _owner = value; } }

    private void Awake() { _checkActive = false; }

    private void Update()
    {
        if (CurrentPowerUp == null)
            _checkActive = false;
        else
            _checkActive = true;
    }

    /// <summary>
    /// How the power up functions
    /// </summary>
    /// <param name="arg">The arguments to have the power up function</param>
    public virtual void Activate(params object[] arg)
    {
    }
}
