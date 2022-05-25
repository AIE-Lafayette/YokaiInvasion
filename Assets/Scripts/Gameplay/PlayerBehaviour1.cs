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

        if (other.tag == "ninja")
            NinjaHolderBehaviour.Instace.setActiveSpawners();
        
    }
}
