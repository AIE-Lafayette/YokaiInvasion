using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathWallbehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
          GameManager.Instace.UpdateGamestate(GameState.EndScreen);
        }
        if (other.tag == "Untagged")
            return;
    }
}
