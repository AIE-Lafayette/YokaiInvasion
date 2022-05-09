using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    int health;

    //on collision
    private void OnTriggerEnter(Collider other)
    {
        //lower health by one
        health--;
    }
    public virtual void OnDeath()
    {

    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    health--;
        //}

        //If health reaches 0 
        if (health <= 0)
        {
            //destroy the game object
            Destroy(gameObject);
        }


    }
}
