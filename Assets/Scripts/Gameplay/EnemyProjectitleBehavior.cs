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
        //The higher the bulletcooldown the long it takes to fire
        _bulletTimer += Time.deltaTime;
        //only fire when the timmer is greater than cooldown
        if (_bulletTimer >= _bulletCooldown)
        {
            _gun.Fire();
            //resets timer
            _bulletTimer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == OwnerTag)
            return;
    }
}
