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
        if (other.tag == "Ninja")
            Destroy(other);
        if (other.tag == "Rage")
            Destroy(other);
        if (other.tag == "ToriGate")
            EnvironmentSpawnerHolder.Instace.DestroyTheEnviroment();
        if (other.tag == "Lanter")
            Destroy(other);
        if (other.tag == "Untagged")
            return;
    }
}
