using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehavior : UsePowerUpBehavior
{
    [SerializeField]
    private GameObject _ninja;
    private bool _active = false;

    public GameObject Ninja
    {
        get { return _ninja; }
        set { _ninja = value; }
    }

    private void Awake()
    {
        Activate();
    }

    /// <summary>
    /// Turns on the ninjas and can start using there helps
    /// </summary>
    public override void Activate(params object[] arguments)
    {
        // Creates an instance of the Routine Behavior or copies the instance of it.
        RoutineBehaviour routineBehavior = RoutineBehaviour.Instance;
        //instanates the ninja 
        SummonHelper();
        _ninja.SetActive(true);
        // Attempts to set up a timed action where the powerup will be set back to inactive.
        routineBehavior.StartNewTimedAction(arguments => _ninja.SetActive(false), TimedActionCountType.SCALEDTIME, 10.0f);
    }

    private void SummonHelper()
    {
        if (_active)
        {
            //instatiats the bullet and the position that it spawns, and its rotation.
            GameObject helper = Instantiate(_ninja.gameObject, transform.position, transform.rotation);
            helper.transform.SetParent(Owner.transform);
            _active = false;
        }

        //once its not active removes the helper
        if (_ninja.activeSelf == false)
        {
            _active = false;
            Destroy(_ninja);
        }
    }
}
