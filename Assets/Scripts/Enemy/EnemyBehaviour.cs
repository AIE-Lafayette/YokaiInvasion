using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyBehaviour _enemyBehaviour;
    [SerializeField]
    private float _damage;
    private HealthBehavior _healthBehavior;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// called when the posistion of the other and the transform of the enemy is the same
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (!_enemyBehaviour)//if not enemy behaviour
        {
            //is the posistion of other and this the same
            if (transform.position == other.transform.position)
                _healthBehavior.TakeDamage(_damage);//decrements health
        }
    }
}
