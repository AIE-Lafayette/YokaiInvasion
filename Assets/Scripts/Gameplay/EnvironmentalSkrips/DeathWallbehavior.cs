using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathWallbehavior : MonoBehaviour
{
    /// <summary>
    /// This is called when a collision will happen
    /// </summary>
    /// <param name="other">other than a enemy colliing everthing else is destroyed on thouch</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            GameManager.Instace.UpdateGamestate(GameState.EndScreen);
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
