using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPowerUpBehavior : UsePowerUpBehavior
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
        Activate();
    }

    private void Start() 
    {
        //_ninjaRef.SetActive(true);
        SummonHelper();
    }

    /// <summary>
    /// Turns on the ninjas and can start using there helps
    /// </summary>
    public override void Activate(params object[] arguments)
    {
        if (_active == true)
        {
            // Creates an instance of the Routine Behavior or copies the instance of it.
            RoutineBehaviour routineBehavior = RoutineBehaviour.Instance;
            //instanates the ninja 

            //_ninjaRef.SetActive(true);       
            // Attempts to set up a timed action where the powerup will be set back to inactive.
            routineBehavior.StartNewTimedAction(arguments => _ninjaRef.SetActive(false), TimedActionCountType.SCALEDTIME, 2.0f);
        }
        
    }

    private void SummonHelper()
    {
        if (_active == false)
        {
            //instatiats the bullet and the position that it spawns, and its rotation.
            GameObject helper = Instantiate(_ninjaRef.gameObject, transform.position, transform.rotation);
            //helper.transform.SetParent(Owner.transform);
            _active = true;
        }

        ////once its not active removes the helper
        //if (_ninjaRef.activeSelf == false)
        //{
        //    _active = false;
        //    Destroy(_ninjaRef);
        //}
    }
}
