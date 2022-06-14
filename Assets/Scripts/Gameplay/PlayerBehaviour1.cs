using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerBehaviour1 : HealthBehavior
{
    public override void OnDeath()
    {
        base.OnDeath();
        GameManager.Instace.UpdateGamestate(GameState.EndScreen);
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyBehaviour enemyBehaviour = other.GetComponent<EnemyBehaviour>();
        if (other.tag == "Enemy")
            TakeDamage(enemyBehaviour.Damage);
        //starts the ninjas
        if (other.tag == "Ninja")
        {
            NinjaHolderBehaviour.Instace.setActiveSpawners();
            Destroy(other);
        }

    }
}
