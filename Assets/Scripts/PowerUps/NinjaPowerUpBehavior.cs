using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehavior : PowerUpBehavior
{
    [SerializeField]
    private GameObject _ninjaRef;
    private bool _active;

    public GameObject NinjaRef
    {
        get { return _ninjaRef; }
        set { _ninjaRef = value; }
    }

    private void Awake()
    {

    }

    /// <summary>
    /// activates the enemy projectilte so it fires down its lane
    /// changes the material so show that it is active
    /// </summary>
    public void SpawnHelper()
    {
        //checks the players collision if they collide with the power up with ninja tag
        //sets active to true
    }

    /// <summary>
    /// While it is active it will fire until time is up then set it to not active
    /// </summary>
    public override void Activate(params object[] arguments)
    {
        if (_active)
        {
            // Creates an instance of the Routine Behavior or copies the instance of it.
            RoutineBehaviour routineBehavior = RoutineBehaviour.Instance;
            //instanates the ninja 
            SpawnHelper();
            // Attempts to set up a timed action where the powerup will be set back to inactive.
            routineBehavior.StartNewTimedAction(arguments => SpawnHelper(), TimedActionCountType.SCALEDTIME, 2.0f);
        }
        
    }


}
