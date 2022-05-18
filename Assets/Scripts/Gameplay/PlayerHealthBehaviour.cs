using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealthBehaviour : HealthBehavior
{
    public override void OnDeath()
    {
        base.OnDeath();
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyBehaviour enemyBehaviour = other.GetComponent<EnemyBehaviour>();
        if (tag != other.tag)
            TakeDamage(enemyBehaviour.Damage);
    }

}
