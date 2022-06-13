using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentBehavior : MonoBehaviour
{
    private int _hitCount;
    private void Update()
    {
        if (GameManager.Instace.State != GameState.AdvanceForward)
            GetComponent<MovementBehavior>().Speed = 0;
        if (GameManager.Instace.State == GameState.AdvanceForward)
            GetComponent<MovementBehavior>().Speed = 40;
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Wall")
        //{
        //    _hitCount++;
        //    if (_hitCount <= 1)
        //    {
        //        for (int i = 0; i < EnviromentSpawnerBehviour.Instace._arrayEnviromentRef.Length; i++)
        //        {
                    
        //        }
        //    }
                
        //}
    }
}
