using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaHolderBehaviour : MonoBehaviour
{
    public static NinjaHolderBehaviour Instace;
    [SerializeField]
    private NinjaBehvoaur[] _ninjas;

    private void Awake() { Instace = this; }

    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {

        //loops through the array...
        for (int i = 0; i < _ninjas.Length; i++)
        {
            //sets each index's active to true
            _ninjas[i].gameObject.SetActive(true);
        }
    }
}
