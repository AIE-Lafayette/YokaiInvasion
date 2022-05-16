using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehvior : PowerUpBehavior
{
    private UsePowerUpBehavior _abilityScript;
    [SerializeField]
    private GameObject _ninja;

    public GameObject Ninja
    {
        get { return _ninja; }
        set { _ninja = value; }
    }

    /// <summary>
    /// sets the current power up to be the ninja behavior
    /// </summary>
    public void Awake()
    {
        _abilityScript.CurrentPowerUp = new NinjaPowerUpBehvior();
    }

    /// <summary>
    /// Turns on the ninjas and can start using there helps
    /// </summary>
    public override void Activate(params object[] arguments)
    {
        // Creates an instance of the Routine Behavior or copies the instance of it.
        RoutineBehaviour routineBehavior = RoutineBehaviour.Instance;
        _ninja.SetActive(true);
        // Attempts to set up a timed action where the grab radius will be set back to inactive.
        routineBehavior.StartNewTimedAction(arguments => _ninja.SetActive(false), TimedActionCountType.SCALEDTIME, 0.5f);
    }

    public void Update()
    {
        if (_ninja == true)
        {
            GameObject helper = Instantiate(_ninja.gameObject, transform.position, transform.rotation);
            helper.transform.SetParent(Owner.transform);
        }
    }
}
