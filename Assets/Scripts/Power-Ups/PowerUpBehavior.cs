using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject _owner;
    private GameObject _visualPrefab;

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
