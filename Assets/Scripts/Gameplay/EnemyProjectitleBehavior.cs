using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectitleBehavior : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private FireBehaviour _gun;
    [SerializeField]
    private float _bulletCooldown;
    [SerializeField]
    private bool _destroyOnHit;
    private float _bulletTimer;

    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }

    // Update is called once per frame
    void Update()
    {
        _bulletTimer += Time.deltaTime;

        if (_bulletTimer >= _bulletCooldown)
        {
            _gun.Fire();
            _bulletTimer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == OwnerTag)
            return;

        //HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        //if (!otherHealth)
        //    return;

        //otherHealth.TakeDamge(_damage);

        if (_destroyOnHit)
            Destroy(gameObject);
    }
}
