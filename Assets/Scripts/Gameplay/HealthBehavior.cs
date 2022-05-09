using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    int health;

    private void OnTriggerEnter(Collider other)
    {
        health--;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }

        if (health <= 0)
        {
            SceneManager.LoadScene("ZachTestScene");
        }
    }
}
