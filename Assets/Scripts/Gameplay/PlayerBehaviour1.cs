using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerBehaviour1 : HealthBehavior
{
    private EnemyBehaviour enemyBehaviour;
    public override void OnDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        base.OnDeath();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (transform.position == other.transform.position)
            TakeDamage(2);
    }
}
