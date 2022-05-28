using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaHolderBehaviour : MonoBehaviour
{
    public static NinjaHolderBehaviour Instace;
    [SerializeField]
    private NinjaSpawnerBehviour[] ninjaSpawnerBehavior;

    private void Awake() { Instace = this; }

    // Update is called once per frame
    /// <summary>
    /// set the spawner instences to be active
    /// </summary>
    public void setActiveSpawners()
    {
        //loops through the array...
        for (int i = 0; i < ninjaSpawnerBehavior.Length; i++)
        {
            //sets each index's active to true
            ninjaSpawnerBehavior[i].IsActive = true;
        }
    }
}
