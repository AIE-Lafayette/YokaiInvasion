using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectitleBehaviour : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _lifeTime;
    [SerializeField]
    private bool _destroyOnHit;
    private float _currentLifeTime;
    private Rigidbody _rigidbody;

    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }

    public Rigidbody RigidBody
    {
        get { return _rigidbody; }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //checks if its the ownertag
        if (other.tag == OwnerTag)
            return;

        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        if (!otherHealth)
            return;

        otherHealth.TakeDamage(_damage);

        //destroys the bullet on collision
        if (_destroyOnHit)
            Destroy(gameObject);
    }
    private void Update()
    {
        //The time until it deletes 
        _currentLifeTime += Time.deltaTime;
        //if the current life time is greater or equal to the life time
        if (_currentLifeTime >= _lifeTime)
            Destroy(gameObject);//destroy self
    }
}
