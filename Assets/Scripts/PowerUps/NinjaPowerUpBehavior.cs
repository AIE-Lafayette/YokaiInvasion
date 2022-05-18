using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehavior : UsePowerUpBehavior
{
    [SerializeField]
    private GameObject _ninjaRef;

    public GameObject NinjaRef
    {
        get { return _ninjaRef; }
        set { _ninjaRef = value; }
    }

    private void Awake()
    {
    }

    private void Start() 
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
            _ninjaRef.SetActive(false);       
            // Attempts to set up a timed action where the powerup will be set back to inactive.
            routineBehavior.StartNewTimedAction(arguments => _ninjaRef.SetActive(true), TimedActionCountType.SCALEDTIME, 5.0f);
    }
}
