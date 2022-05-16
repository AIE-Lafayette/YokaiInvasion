using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerBehaviour1 : HealthBehavior
{
    public override void OnDeath()
    {
        base.OnDeath();
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyBehaviour enemyBehaviour = other.GetComponent<EnemyBehaviour>();
        if (transform.position == other.transform.position)
            TakeDamage(enemyBehaviour.Damage);
    }
}
