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

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    health--;
        //}

        //If health reaches 0 then reload the scene
        if (health <= 0)
        {
            //reload the scene
            SceneManager.LoadScene("ZachTestScene");
        }
    }
}
