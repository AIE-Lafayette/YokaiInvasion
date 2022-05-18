using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehavior : UsePowerUpBehavior
{

    [SerializeField]
    private GameObject _ninja;

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


        //once its not active removes the helper
        if (_ninja.activeSelf == false)
        {
            Destroy(_ninja);
        }
    }
}
