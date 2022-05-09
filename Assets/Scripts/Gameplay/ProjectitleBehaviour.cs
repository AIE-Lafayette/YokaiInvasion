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

        //HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        //if (!otherHealth)
        //    return;

        //otherHealth.TakeDamge(_damage);

        //destroys the bullet on collision
        if (_destroyOnHit)
            Destroy(gameObject);
    }
    private void Update()
    {
        //The time until it deletes 
        _currentLifeTime += Time.deltaTime;
        if (_currentLifeTime >= _lifeTime)
            Destroy(gameObject);
    }
}
