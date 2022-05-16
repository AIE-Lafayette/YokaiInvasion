using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWallbehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindWithTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
    }
}
