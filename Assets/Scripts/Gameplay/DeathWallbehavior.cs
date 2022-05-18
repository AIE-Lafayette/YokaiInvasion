using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathWallbehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (GameObject.FindWithTag("Untagged"))
            return;
    }
}
